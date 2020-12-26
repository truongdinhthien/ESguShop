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
        private readonly IAsyncRepository<ComboDetail> _comboDetailRepository;

        public OrderService(IAsyncRepository<Order> orderRepository,
            IAsyncRepository<Combo> comboRepository,
            IAsyncRepository<Product> productRepository,
            IAsyncRepository<Storage> storageRepository,
            IAsyncRepository<ComboDetail> comboDetailRepository)
        {
            _orderRepository = orderRepository;
            _comboRepository = comboRepository;
            _productRepository = productRepository;
            _storageRepository = storageRepository;
            _comboDetailRepository = comboDetailRepository;
        }

        public async Task<Order> AddAsync(Order order)
        {
            //Should use transaction but so lazy :(
            var orderAdded = await _orderRepository.AddAsync(order);
            if (orderAdded == null) return null;
            else
            {
                await GetStockExchangesFromOrder(orderAdded);
                return orderAdded;
            }
        }

        private async Task GetStockExchangesFromOrder(Order order)
        {
            var stockExchanges = order.OrderDetails.Select(od => new StockExchange
            {
                ItemId = od.ItemId,
                Quantity = od.Quantity,
                IsCombo = od.IsCombo,
            }).ToList();
            var listProduct = await _productRepository.ListAsync();
            foreach (var item in stockExchanges)
            {
                if (item.IsCombo == true)
                {
                    var listComboDetail = await _comboDetailRepository.ListAsync();
                    var selectedComboDetails = listComboDetail.FindAll(d => item.ItemId == d.ComboId);

                    foreach (var p in listProduct)
                    {
                        var selectedProduct = selectedComboDetails.Find(d => d.ProductId == p.Id);

                        if (selectedProduct != null)
                        {
                            var stockProduct = new StockExchange
                            {
                                ItemId = selectedProduct.ProductId,
                                Quantity = selectedProduct.Quantity * item.Quantity,
                                IsCombo = true
                            };

                            await updateStock(p, stockProduct);
                        }
                    }
                }
                else
                {
                    foreach (var p in listProduct)
                    {
                        await updateStock(p, item);
                    }
                }
            }
        }
        private async Task updateStock(Product pInStock, StockExchange oDetail)
        {
            if (oDetail.ItemId == pInStock.Id)
            {
                pInStock.Quantity -= oDetail.Quantity;
                if (pInStock.Quantity >= 0)
                    await _productRepository.UpdateAsync(pInStock);
                //else
                //{
                //    //todo: show message and remove created order + oderdetails 
                //    //when there is not enough product in stock
                //}
            }
        }

        public async Task<IEnumerable<Order>> GetOrdersByCustomer(int id)
        {
            return await _orderRepository.ListAsync(o => o.CustomerId == id);
        }

        public async Task<IEnumerable<Order>> GetOrdersAsync()
        {
            return await _orderRepository.ListAsync();
        }
    }
}
