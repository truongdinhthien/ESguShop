using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Common
{
    public class StockExchange
    {
        public string ItemId { get; set; }
        public int Quantity { get; set; }
        public bool IsCombo { get; set; }
    }
}
