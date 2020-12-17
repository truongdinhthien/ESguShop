using BUS.Customers.Interface;
using Core.Common.Interfaces;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Customers
{
    public class CustomerService : ICustomerService
    {
        private readonly IAsyncRepository<Customer> _customerRepository;
        public CustomerService(IAsyncRepository<Customer> customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public async Task<Customer> AddAsync(Customer customer)
        {
            return await _customerRepository.AddAsync(customer);
        }

        public async Task<Customer> GetByUserIdAsync(string id)
        {
            var customer = await _customerRepository.ListAsync(c => c.UserId == id);
            return customer.FirstOrDefault();
        }
    }
}
