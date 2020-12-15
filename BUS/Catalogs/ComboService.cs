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
        public ComboService(IAsyncRepository<Combo> comboRepository)
        {
            _comboRepository = comboRepository;
        }
        public async Task<IEnumerable<Combo>> ListAsync()
        {
            return await _comboRepository.ListAsync();
        }
    }
}
