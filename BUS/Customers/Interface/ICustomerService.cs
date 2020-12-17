using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Customers.Interface
{
    public interface ICustomerService
    {
        Task<Customer> AddAsync(Customer customer);
        Task<Customer> GetByUserIdAsync(string id);
    }
}
