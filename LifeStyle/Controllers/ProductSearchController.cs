using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.Home;
using Core.Entities;

namespace LifeStyle.Controllers
{
    public class ProductSearchController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductImageService _productImageService;
        private readonly IGenderCategoryService _genderCategoryService;
        private readonly IProductCategoryService _productCategoryService;
        public ProductSearchController( IProductCategoryService productCategoryService, IGenderCategoryService genderCategoryService, IProductService productService, IProductImageService productImageService)
        {
            _productCategoryService = productCategoryService;
            _genderCategoryService = genderCategoryService;
            _productService = productService;
            _productImageService = productImageService;
        }
        public async Task<IActionResult> Index()
        {
            var category = await _productCategoryService.GetAllAsync();
            var gender = await _genderCategoryService.GetAllAsync();
            var product = await _productService.GetAllAsync();
            var productImage = await _productImageService.GetAllAsync();
            var homeVM = new HomeVM()
            {
                ProductCategories = category,
                GenderCategory = gender,
                Product = product,
                ProductImages = productImage
            };
            return View(homeVM);
        }
    }
}
