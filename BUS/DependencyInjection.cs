using BUS.Catalogs;
using BUS.Catalogs.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BUS
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegistBUS(this IServiceCollection services)
        {
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IComboService, ComboService>();
            return services;
        }
    }
}
