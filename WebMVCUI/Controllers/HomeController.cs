using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebMVCUI.Models;
using BUS.Catalogs.Interfaces;
using Core.Entities;

namespace WebMVCUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IProductService _productService;
        private readonly IComboService _comboService;

        public HomeController(ILogger<HomeController> logger,
                              IProductService productService,
                              IComboService comboService)
        {
            _logger = logger;
            _comboService = comboService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Product> products = await _productService.ListAsync();
            IEnumerable<Combo> combos = await _comboService.ListAsync();
            HomeViewModel homeViewModel = new HomeViewModel
            {
                Products = products.ToList(),
                Combos = combos.ToList()
            };
            return View(homeViewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
