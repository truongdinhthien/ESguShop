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
using WebMVCUI.Models;
using WebMVCUI.Service.Interfaces;

namespace WebMVCUI.Areas.Identity.Pages.Account.Manage
{
    public class IndexModel : PageModel
    {
        private ICurrentBuyerService _currentBuyerService;

        public IndexModel(ICurrentBuyerService currentBuyerService)
        {
            _currentBuyerService = currentBuyerService;
        }

        [BindProperty]
        public CustomerModel Customer { get; set; }
        public async Task<IActionResult> OnGetAsync()
        {
            var returnUrl = Url.Content("~/");
            var buyer = await _currentBuyerService.GetInformation(User);
            if(buyer ==  null) return LocalRedirect(returnUrl);
            Customer = buyer;
            return Page();
        }
    }
}
