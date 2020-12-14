﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ComboDetail
    {
        public int ComboId { get; set; }
        public int ProductId { get; set; }
        public virtual Combo Combo { get; set; }
        public virtual Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
