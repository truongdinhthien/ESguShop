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
        public ProductService(IAsyncRepository<Product> productRepository)
        {
            _productRepository = productRepository;
        }
        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _productRepository.ListAsync();
        }
    }
}
