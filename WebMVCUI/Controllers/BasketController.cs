using BUS.Catalogs.Interfaces;
using BUS.Customers.Interface;
using BUS.Orders.Interfaces;
using Core.Entities;
using Core.Enumerations;
using DAL.Identity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using WebMVCUI.Helper;
using WebMVCUI.Models;
using WebMVCUI.Service.Interfaces;

namespace WebMVCUI.Controllers
{
    public class BasketController : Controller
    {
        private readonly IProductService _productService;
        private readonly IComboService _comboService;
        private readonly IOrderService _orderService;
        private ICurrentBuyerService _currentBuyerService;

        public BasketController(
            IProductService productService,
            IComboService comboService,
            IOrderService orderService,
            ICurrentBuyerService currentBuyerService)
        {
            _productService = productService;
            _comboService = comboService;
            _currentBuyerService = currentBuyerService;
            _orderService = orderService;
        }

        public IActionResult Index()
        {
            var currentBasket = HttpContext.Session?.GetObjectFromJson<BasketViewModel>("basket");
            return View(currentBasket);
        }
        [Route("/Basket/AddToCart")]
        [HttpPost]
        public async Task<IActionResult> AddToBasketAsync(string id, int amount = 1)
        {
            var currentBasket = HttpContext.Session?.GetObjectFromJson<BasketViewModel>("basket");
            var currentBasketItemList = currentBasket?.BasketItems?.ToList();
            if (currentBasket == null)
            {
                var newBasket = new BasketViewModel();
                var newBasketList = new List<BasketItem>();
                var newBasketItem = await this.MappingToBasketItem(id, amount);
                if (newBasketItem != null)
                {
                    newBasketList.Add(newBasketItem);
                    newBasket.BasketItems = newBasketList;
                    HttpContext.Session?.SetObjectAsJson("basket", newBasket);
                    return Ok(newBasket);
                }
                return StatusCode(500, "Not enough in stock");
            }    
            else
            {
                var itemFound = currentBasket.BasketItems.Where(c => c.ItemId == id).SingleOrDefault();
                
                if(itemFound == null)
                {
                    var newCartItem = await this.MappingToBasketItem(id, amount);
                    if (newCartItem == null)
                        return StatusCode(500, "Not enough in stock");

                    currentBasketItemList.Add(newCartItem);
                    currentBasket.BasketItems = currentBasketItemList;
                }    
                else
                {
                    var currentItem = currentBasket.BasketItems.Where(item => item.ItemId == id).ToList().ElementAt(0);
                    var p = await _productService.GetByIdAsync(id);
                    // If found => its a product
                    if(p != null) {
                        if (p.Quantity < amount + await GetCurrentProductAmountInOrder(id))
                            return StatusCode(500, "Not enough in stock");
                    }

                    // If not => its a combo
                    else
                    {
                        var combo = await _comboService.GetByIdAsync(id);
                        var avail = await GetComboAvailability(id,amount);
                        if(!avail)
                            return StatusCode(500, "Not enough in stock");
                    }
                    itemFound.Amount += amount;
                }
                HttpContext.Session?.SetObjectAsJson("basket", currentBasket);
                return Ok(currentBasket);
            }


        }
        [Route("/Basket/DeleteAllCart")]
        [HttpPost]
        public IActionResult DeleteAllCartAsync()
        {
            HttpContext.Session?.SetObjectAsJson("basket", null);
            return PartialView("_Basket", null);
        }
        [Route("/Basket/CheckOut")]
        [HttpPost]
        public async Task<IActionResult> CheckOutAsync(
            [Required]
            string deliveryAddress,
            [Required]
            DateTime deliveryDateTime
        )
        {

            var currentBasket = HttpContext.Session?.GetObjectFromJson<BasketViewModel>("basket");
            var currentBasketItemList = currentBasket?.BasketItems?.ToList();
            if(currentBasketItemList == null) return BadRequest("Giỏ hàng trống");

            var buyer = await _currentBuyerService.GetInformation(User);
            if (buyer == null) return BadRequest("Bạn cần đăng nhập để có thể thanh toán");

            if (!ModelState.IsValid) return BadRequest("Thông tin không được bỏ trống");

            var order = await _orderService.AddAsync(new Order
            {
                Status = OrderStatus.New,
                DeliveryDate = deliveryDateTime,
                DeliveryAddress = deliveryAddress,
                CustomerId = buyer.Id,
                TotalPrice = currentBasket.TotalPrice,
                OrderDetails = currentBasket.BasketItems.Select(ele => new OrderDetail
                {
                    ItemId = ele.ItemId,
                    Price = ele.Price,
                    Quantity = ele.Amount,
                    IsCombo = ele.IsCombo,
                }).ToList(),
            });

            if (order != null)
            {
                HttpContext.Session?.SetObjectAsJson("basket", null);
                return PartialView("_Basket", null);
            }
            return BadRequest("Something not right right");
        }

        private async Task<BasketItem> MappingToBasketItem(string id, int amount)
        {
            BasketItem currentItem;
            List<BasketItem> currentItemInBasket;
            var currentBasket = HttpContext.Session?.GetObjectFromJson<BasketViewModel>("basket");
            if (currentBasket == null)
                currentItemInBasket = null;
            else
                currentItemInBasket = currentBasket.BasketItems.Where(item => item.ItemId == id).ToList();

            if (currentItemInBasket != null && currentItemInBasket.Count() > 0)
            {
                currentItem = currentItemInBasket.ElementAt(0);
            }
            else
            {
                currentItem = new BasketItem();
                currentItem.Amount = 0;
            }

            var product = await _productService.GetByIdAsync(id);
            if (product != null)
                if ( product.Quantity < amount + await GetCurrentProductAmountInOrder(id))
                    return null;
                else
                    return new BasketItem
                {
                    ItemId = product.Id,
                    IsCombo = false,
                    Price = product.Price,
                    Amount = amount,
                    Name = product.Name,
                    TotalPrice = product.Price * amount
                };
            else
            {
                var combo = await _comboService.GetByIdAsync(id);

                if (combo != null)
                {
                    foreach (ComboDetail d in combo.ComboDetails.ToList())
                    {
                        var avail = await GetComboAvailability(d.ComboId,amount);
                        if (!avail)
                        {
                            return null;
                        }
                    }
                    return new BasketItem
                    {
                        ItemId = combo.Id,
                        IsCombo = true,
                        Price = combo.Price,
                        Amount = amount,
                        Name = combo.Name,
                        TotalPrice = combo.Price * amount
                    };
                }
                else return null;
            }
        }

        private async Task<int> GetCurrentProductAmountInOrder(string id)
        {
            var currentBasket = HttpContext.Session?.GetObjectFromJson<BasketViewModel>("basket");
            int count = 0;
            
            if(currentBasket != null)
            {
                var currentItemList = currentBasket.BasketItems.Where(item => item.ItemId == id).ToList();
                // If its a product
                if (currentItemList != null && currentItemList.Count > 0)
                {
                    var currentItem = currentItemList.ElementAt(0);
                    count += currentItem.Amount;
                }
                // Check all combos in in basket if they included this product
                var basketCombos = currentBasket.BasketItems.Where(c => c.IsCombo).ToList();
                foreach (BasketItem c in basketCombos)
                {
                    var currentCombo = await _comboService.GetByIdAsync(c.ItemId);
                    var currentProductInCombo = currentCombo.ComboDetails.Where(d => d.ProductId == id).ToList().ElementAt(0);
                    count += c.Amount * currentProductInCombo.Quantity;
                }
            }
            return count;
        }

        private async Task<bool> GetComboAvailability(string id, int amount)
        {
            //var currentBasket = HttpContext.Session?.GetObjectFromJson<BasketViewModel>("basket");
            //if (currentBasket != null)
            //{
                //var currentComboInOrder = currentBasket.BasketItems.Where(item => item.ItemId == id).ToList();
                //if (currentComboInOrder != null && currentComboInOrder.Count > 0)
                //{
                    //var currentItem = currentComboInOrder.ElementAt(0);
                    //if (currentItem.IsCombo)
                    //{
                        // Get all product in current combo
                        var currentCombo = await _comboService.GetByIdAsync(id);
                        var productsInCurrentCombo = currentCombo.ComboDetails.ToList();
                        foreach (ComboDetail c in productsInCurrentCombo)
                        {
                            var productInStock = await _productService.GetByIdAsync(c.ProductId);
                            var stockAmount = productInStock.Quantity;
                            if (await GetCurrentProductAmountInOrder(c.ProductId) + c.Quantity * amount > stockAmount)
                            {
                                return false;
                            }
                        }
                    //}
                    //else
                    //    return false;
                //}
                
            //}
            //else
            //    return false;
            return true;
        }
    }
}
