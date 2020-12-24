using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class OrderDetail
    {
        public int OrderId { get; set; }
        public virtual Order Order { get; set; }
        //This item is can be a combo or a product
        public string ItemId { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        [NotMapped]
        public bool IsCombo { get; set; }
    }
}
