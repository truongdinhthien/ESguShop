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
                else throw new Exception("Not found id");
            }    
            else
            {
                var itemFound = currentBasket.BasketItems.Where(c => c.ItemId == id).SingleOrDefault();
                if(itemFound == null)
                {
                    var newCartItem = await this.MappingToBasketItem(id, amount);
                    currentBasketItemList.Add(newCartItem);

                    currentBasket.BasketItems = currentBasketItemList;
                }    
                else
                {
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
                    Quantity = ele.Amount
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
            var product = await _productService.GetByIdAsync(id);
            if (product != null)
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
                    return new BasketItem
                    {
                        ItemId = combo.Id,
                        IsCombo = true,
                        Price = combo.Price,
                        Amount = amount,
                        Name = combo.Name,
                        TotalPrice = combo.Price * amount
                    };
                else return null;
            }
        }
    }
}
