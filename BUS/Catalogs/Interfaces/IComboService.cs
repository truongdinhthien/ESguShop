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
    }
}
