using BUS;
using BUS.Catalogs;
using BUS.Catalogs.Interfaces;
using BUS.Orders;
using BUS.Orders.Interfaces;
using DAL;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformUI
{
    static class Program
    {

        private static IConfiguration _configuration;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            _configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", true, true)
                .Build();

            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var services = new ServiceCollection();
            ConfigureServices(services);


            using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            {
                //Run form
                var mainFrame = serviceProvider.GetRequiredService<Form1>();
                Application.Run(mainFrame);
            }
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            services.RegistDALTransient(_configuration);
            services.RegistBUS();

            services.AddScoped<Form1>();
        }
    }
}
