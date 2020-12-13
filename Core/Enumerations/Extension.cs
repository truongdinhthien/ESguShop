using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Enumerations
{
    public static class ExtensionExtension
    {
        public static string Convert(this OrderStatus status)
        {
            switch (status)
            {
                case OrderStatus.New: return "Khởi tạo";
                case OrderStatus.Delivering: return "Đang giao hàng";
                case OrderStatus.Deilivered: return "Đã giao hàng";
                default: return "";
            }
        }

        public static string Convert(this ProductType type)
        {
            switch (type)
            {
                case ProductType.Misc: return "Khác";
                case ProductType.Laptop: return "Máy tính xách tay";
                case ProductType.Keyboard: return "Bàn phím";
                case ProductType.Mouse: return "Chuột";
                case ProductType.PC: return "Máy tính bàn";
                default: return "";
            }
        }
    }
}
