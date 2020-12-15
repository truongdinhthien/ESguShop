using BUS.Catalogs.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMVCUI.Controllers
{
    public class ComboController : Controller
    {
        private readonly IComboService _comboService;
        public ComboController(IComboService comboService)
        {
            _comboService = comboService;
        }
        public async Task<IActionResult> IndexAsync()
        {
            return View(await _comboService.ListAsync());
        }
    }
}
