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
        private readonly IProductService _productService;
        private readonly IProductBFOSService _productBfosService;
        private readonly IProductImageService _productImageService;
        private readonly IGenderCategoryService _genderCategoryService;
        public HomeController(ISliderService sliderService, IProductBFOSService productBfosService, IGenderCategoryService genderCategoryService, IProductService productService, IProductImageService productImageService)
        {
            _sliderService = sliderService;
            _genderCategoryService = genderCategoryService;
            _productService = productService;
            _productImageService = productImageService;
            _productBfosService = productBfosService;
        }
        public async Task<IActionResult> Index()
        {
            var sliders = await _sliderService.GetAllAsync();
            var gender = await _genderCategoryService.GetAllAsync();
            var product = await _productService.GetAllAsync();
            var productImage = await _productImageService.GetAllAsync();
            var homeVM = new HomeVM()
            {
                Sliders = sliders,
                GenderCategory = gender,
                Product = product,
                ProductImages = productImage
            };
            return View(homeVM);
        }

      
    }
}
