using BUS.Orders.Interfaces;
using Core.Common;
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
        private readonly IAsyncRepository<Combo> _comboRepository;
        private readonly IAsyncRepository<Product> _productRepository;
        private readonly IAsyncRepository<Storage> _storageRepository;

        public OrderService(IAsyncRepository<Order> orderRepository, 
            IAsyncRepository<Combo> comboRepository,
            IAsyncRepository<Product> productRepository,
            IAsyncRepository<Storage> storageRepository)
        {
            _orderRepository = orderRepository;
            _comboRepository = comboRepository;
            _productRepository = productRepository;
            _storageRepository = storageRepository;
        }

        public async Task<Order> AddAsync(Order order)
        {
            //Should use transaction but so lazy :(
            var orderAdded = await _orderRepository.AddAsync(order);
            if (orderAdded == null) return null;
            else
            {
                var stockExchanges = this.GetStockExchangesFromOrder(orderAdded);
                return orderAdded;
            }
        }

        private async Task GetStockExchangesFromOrder (Order order)
        {
            var stockExchanges = order.OrderDetails.Select(od => new StockExchange
            {
                ItemId = od.ItemId,
                Quantity = od.Quantity,
                IsCombo = od.IsCombo,
            }).ToList();

            //foreach(var item in )
        }

        public async Task<IEnumerable<Order>> GetOrdersByCustomer(int id)
        {
            return await _orderRepository.ListAsync(o => o.CustomerId == id);
        }
    }
}
