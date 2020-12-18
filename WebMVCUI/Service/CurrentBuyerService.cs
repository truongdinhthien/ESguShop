using BUS.Customers.Interface;
using DAL.Identity;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebMVCUI.Models;
using WebMVCUI.Service.Interfaces;

namespace WebMVCUI.Service
{
    public class CurrentBuyerService : ICurrentBuyerService
    {
        private readonly ICustomerService _customerService;
        private readonly UserManager<ApplicationUser> _userManager;

        public CurrentBuyerService(ICustomerService customerService, UserManager<ApplicationUser> userManager)
        {
            _customerService = customerService;
            _userManager = userManager;
        }

        public async Task<CustomerModel> GetInformation(ClaimsPrincipal User)
        {
            var user = await _userManager.GetUserAsync(User);
            if (user == null)
            {
                return null;
            }
            var customer = await _customerService.GetByUserIdAsync(user.Id);
            return new CustomerModel
            {
                Id = customer.Id,
                FullName = customer.FullName,
                Address = customer.Address,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
                Orders = customer.Orders ?? null,
            };
        }
    }
}
