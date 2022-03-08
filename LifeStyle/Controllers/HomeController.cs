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
        private readonly IGenderCategoryService _genderCategoryService;
        public HomeController(ISliderService sliderService, IGenderCategoryService genderCategoryService)
        {
            _sliderService = sliderService;
            _genderCategoryService = genderCategoryService;
        }
        public async Task<IActionResult> Index()
        {
            var sliders = await _sliderService.GetAllAsync();
            var gender = await _genderCategoryService.GetAllAsync();
            var homeVM = new HomeVM()
            {
                Sliders = sliders,
                GenderCategory = gender
                
            };
            return View(homeVM);
        }
    }
}
