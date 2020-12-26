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
    public class ComboService : IComboService
    {
        public IAsyncRepository<Combo> _comboRepository;
        public IAsyncRepository<ComboDetail> _comboDetailRepository;
        public ComboService(IAsyncRepository<Combo> comboRepository, IAsyncRepository<ComboDetail> comboDetailRepository)
        {
            _comboRepository = comboRepository;
            _comboDetailRepository = comboDetailRepository;
        }

        public async Task<Combo> GetByIdAsync(string id)
        {
            return await _comboRepository.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Combo>> ListAsync()
        {
            return await _comboRepository.ListAsync();
        }

        public async Task UpdateAsync(Combo combo)
        {
            await _comboRepository.UpdateAsync(combo);
        }

        public async Task AddAsync(Combo combo)
        {
            Random generator = new Random();
            int r = generator.Next(100000, 1000000);
            combo.Id = "COMBO-" + r;
            await _comboRepository.AddAsync(combo);
        }

        public async Task AddProductToComboAsync(string comboId, string productId, int quantity)
        {
            ComboDetail comboDetail = new ComboDetail
            {
                ComboId = comboId,
                ProductId = productId,
                Quantity = quantity,
            };

            await _comboDetailRepository.AddAsync(comboDetail);
        }

        public async Task RemoveProductToComboAsync(string comboId, string productId)
        {
            ComboDetail comboDetail = new ComboDetail
            {
                ComboId = comboId,
                ProductId = productId,
            };
            await _comboDetailRepository.DeleteAsync(comboDetail);
        }
    }
}
