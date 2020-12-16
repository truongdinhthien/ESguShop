using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVCUI.Models
{
    public class BasketViewModel
    {
        public IEnumerable<BasketItem> BasketItems { get; set; }
        public decimal TotalPrice { get
            {
                decimal totalPrice = 0;
                foreach (var item in BasketItems)
                {
                    totalPrice += item.TotalPrice;
                }
                return totalPrice;
            }
            set {; } 
        }
        public int TotalAmount { get 
            {
                int totalAmount = 0;
                foreach (var item in BasketItems)
                {
                    totalAmount += item.Amount;
                }
                return totalAmount;
            } 
        }
        public string TotalPriceFormat { get { return string.Format(new CultureInfo("vi-VN", false), "{0:c0}", TotalPrice); } }
    }
    public class BasketItem
    {
        public string ItemId { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public decimal Price { get; set; }
        public bool IsCombo { get; set; }
        public decimal TotalPrice { get { return Amount * Price; } set {; } }
        public string TotalPriceFormat { get { return string.Format(new CultureInfo("vi-VN", false), "{0:c0}", TotalPrice); } }
        public string PriceFormat { get { return string.Format(new CultureInfo("vi-VN", false), "{0:c0}", Price); } }
    }
}
