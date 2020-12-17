using BUS.Orders.Interfaces;
using Core.Common.Interfaces;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Orders
{
    public class OrderService : IOrderService
    {
        private readonly IAsyncRepository<Order> _orderRepository;

        public OrderService(IAsyncRepository<Order> orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public async Task<Order> AddAsync(Order order)
        {
            return await _orderRepository.AddAsync(order);
        }
    }
}
