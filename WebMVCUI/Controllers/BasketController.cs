using BUS.Catalogs.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebMVCUI.Helper;
using WebMVCUI.Models;

namespace WebMVCUI.Controllers
{
    public class BasketController : Controller
    {
        private readonly IProductService _productService;
        private readonly IComboService _comboService;

        public BasketController(IProductService productService, IComboService comboService)
        {
            _productService = productService;
            _comboService = comboService;
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
                var newBasketItem = await this.MappingToCartItem(id, amount);
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
                    var newCartItem = await this.MappingToCartItem(id, amount);
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

        private async Task<BasketItem> MappingToCartItem(string id, int amount)
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
