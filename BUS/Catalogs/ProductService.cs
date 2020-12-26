using BUS.Catalogs.Interfaces;
using Core.Common.Interfaces;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Catalogs
{
    public class ProductService : IProductService
    {
        public IAsyncRepository<Product> _productRepository;
        public IAsyncRepository<Storage> _storageRepository;
        public IAsyncRepository<ComboDetail> _comboDetailRepository;

        public ProductService(IAsyncRepository<Product> productRepository, IAsyncRepository<Storage> storageRepository, IAsyncRepository<ComboDetail> comboDetailRepository)
        {
            _productRepository = productRepository;
            _storageRepository = storageRepository;
            _comboDetailRepository = comboDetailRepository;
        }
        public async Task<Product> GetByIdAsync(string id)
        {
            return await _productRepository.GetByIdAsync(id);
        }
        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }

        public async Task AddAsync(Product product)
        {
            Random generator = new Random();
            int r = generator.Next(100000, 1000000);
            product.Id = "THIETBI-" + r;
            await _productRepository.AddAsync(product);
        }

        public async Task UpdateAsync(Product product)
        {
            await _productRepository.UpdateAsync(product);
        }

        public async Task AddHistoryAsync(Storage storage)
        {
            await _storageRepository.AddAsync(storage);
        }

        public async Task<IEnumerable<Storage>> ListHistoryAsync(string productId)
        {
            return await _storageRepository.ListAsync(
                s => s.ProductId == productId
                );
        }

        public async Task<IEnumerable<Product>> ListAsync(string comboId)
        {
            var comboDetails = await _comboDetailRepository.ListAsync(cbd => cbd.ComboId == comboId);
            var productIds = comboDetails.ConvertAll(cbd => cbd.ProductId);
            var products = await _productRepository.ListAsync(p => productIds.Contains(p.Id));

            foreach (var product in products)
            {
                var match = comboDetails.FirstOrDefault(cbd => cbd.ProductId == product.Id);
                product.Quantity = match.Quantity;
            }
            return products;
        }

        public async Task<IEnumerable<Product>> ListProductNotInComboAsync(string comboId)
        {
            var comboDetails = await _comboDetailRepository.ListAsync(cbd => cbd.ComboId == comboId);
            var productIds = comboDetails.ConvertAll(cbd => cbd.ProductId);
            return await _productRepository.ListAsync(p => !productIds.Contains(p.Id));
        }
    }
}
