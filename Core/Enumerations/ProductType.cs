using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Enumerations
{
    public enum ProductType
    {
        [Description("Khác")]
        Misc,
        [Description("Chuột")]
        Mouse,
        [Description("Bàn phím")]
        Keyboard,
        [Description("Máy tính xách tay")]
        Laptop,
        [Description("Máy bàn")]
        PC,
    }
}
