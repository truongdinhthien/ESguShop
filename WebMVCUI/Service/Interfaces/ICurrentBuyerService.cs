using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using WebMVCUI.Models;

namespace WebMVCUI.Service.Interfaces
{
    public interface ICurrentBuyerService
    {
        Task<CustomerModel> GetInformation(ClaimsPrincipal User);
    }
}
