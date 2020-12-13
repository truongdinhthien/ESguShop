using DAL.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Data
{
    public static class SeedData
    {
        private const string DEFAULT_PASSWORD = "abcd1234";
        public static async Task SeedIdentity(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            if (await userManager.FindByNameAsync("username1@gmail.com") == null)
            {
                var user1 = new ApplicationUser
                {
                    Id = "idseed1",
                    UserName = "username1@gmail.com",
                    Email = "username1@gmail.com",
                };
                await userManager.CreateAsync(user1, DEFAULT_PASSWORD);
            }
        }
    }
}
