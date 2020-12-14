using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Storage
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public DateTime DateChange { get; set; } = DateTime.Now;
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
