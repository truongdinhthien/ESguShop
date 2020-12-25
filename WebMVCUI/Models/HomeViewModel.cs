using System;
using Core.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVCUI.Models
{
    public class HomeViewModel
    {
        public List<Product> Products { get; set; }
        public List<Combo> Combos { get; set; }
    }
}
