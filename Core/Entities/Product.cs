using Core.Enumerations;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Product
    {
        public string Id { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Producer { get; set; }
        public ProductType Type { get; set; }
        public ICollection<ComboDetail> ComboDetails { get; set; } = new List<ComboDetail>();
        [NotMapped]
        public string TypeName { get { return Type.Convert(); } }
    }
}
