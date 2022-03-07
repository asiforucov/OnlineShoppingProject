using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.Home;

namespace LifeStyle.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISliderService _sliderService;
        public HomeController(ISliderService sliderService)
        {
            _sliderService = sliderService;
        }
        public async Task<IActionResult> Index()
        {
            var sliders = await _sliderService.GetAllAsync();
            var homeVM = new HomeVM()
            {
                Sliders = sliders,
                
            };
            return View(homeVM);
        }
    }
}
