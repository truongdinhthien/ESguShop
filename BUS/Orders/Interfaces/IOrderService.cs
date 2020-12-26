using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Orders.Interfaces
{
    public interface IOrderService
    {
        Task<Order> AddAsync(Order order);
        Task<IEnumerable<Order>> GetOrdersByCustomer(int id);
        Task<IEnumerable<Order>> GetOrdersAsync();
        Task<List<OrderDetail>> GetOrderDetailAsync(Order order);
        Task<Order> GetOrderById(int id);
    }
}
