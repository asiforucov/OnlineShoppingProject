using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.Home;
using Microsoft.AspNetCore.Authorization;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class SaleController : Controller
    {
        private readonly ISaleService _saleService;

        public SaleController(ISaleService saleService)
        {
            _saleService = saleService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _saleService.Get());
        }
        public async Task<IActionResult> Update()
        {
            var sale = await _saleService.Get();
            var saleVM = new SaleVM()
            {
                Title = sale.Title,
                Description = sale.Description,
                Time = sale.Time
            };
            return View(saleVM);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Update(SaleVM saleVm)
        {
            if (ModelState.IsValid)
            {
                await _saleService.Update(saleVm);
                return RedirectToAction(nameof(Index));
            }

            return View(saleVm);
        }

    }
}
