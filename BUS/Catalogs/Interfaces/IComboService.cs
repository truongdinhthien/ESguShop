using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Catalogs.Interfaces
{
    public interface IComboService
    {
        Task<IEnumerable<Combo>> ListAsync();
        Task<Combo> GetByIdAsync(string id);
        Task UpdateAsync(Combo combo);
        Task AddAsync(Combo combo);
        Task RemoveProductToComboAsync(string comboId, string productId);
        Task AddProductToComboAsync(string comboId, string productId, int quantity);
    }
}
