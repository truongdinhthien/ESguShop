using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Catalogs.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> ListAsync();
        Task<IEnumerable<Product>> ListAsync(string comboId);
        Task<IEnumerable<Product>> ListProductNotInComboAsync(string comboId);
        Task<Product> GetByIdAsync(string id);
        Task<IEnumerable<Storage>> ListHistoryAsync(string productId);
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task AddHistoryAsync(Storage storage);
    }
}
