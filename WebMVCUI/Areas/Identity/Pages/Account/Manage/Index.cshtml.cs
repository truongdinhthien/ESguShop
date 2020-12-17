using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using BUS.Customers.Interface;
using DAL.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebMVCUI.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private readonly ICustomerService _customerService;
        private readonly UserManager<ApplicationUser> _userManager;

        public IndexModel(ICustomerService customerService, UserManager<ApplicationUser> userManager)
        {
            _customerService = customerService;
            _userManager = userManager;
        }
        [BindProperty]
        public CustomerModel Customer { get; set; }
        public class CustomerModel
        {
            public string FullName { get; set; }
            public string Address { get; set; }
            public string Email { get; set; }
            public string PhoneNumber { get; set; }
        }
        public async Task OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);
            var customer = await _customerService.GetByUserIdAsync(user.Id);
            Customer = new CustomerModel
            {
                FullName = customer.FullName,
                Address = customer.Address,
                Email = user.Email,
                PhoneNumber = user.PhoneNumber,
            };
        }
    }
}
