using DAL.Data;
using DAL.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace DAL
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegistDAL(this IServiceCollection services, IConfiguration configuration)
        {
            //Lazyloading have bad perfomance  
            //https://wildermuth.com/2018/07/28/Avoid-Lazy-Loading-in-ASP-NET
            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                     b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)).UseLazyLoadingProxies());

            services.AddIdentity<ApplicationUser, IdentityRole>(config =>
            {
                config.Password.RequireDigit = false;
                config.Password.RequireNonAlphanumeric = false;
                config.Password.RequireUppercase = false;
                config.Password.RequireLowercase = false;
            }).AddEntityFrameworkStores<ApplicationDbContext>();
            return services;
        }
    }
}
