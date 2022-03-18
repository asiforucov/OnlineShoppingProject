using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.Home;
using Core;

namespace LifeStyle.Controllers
{
    public class SearchController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductImageService _productImageService;
        private readonly IGenderCategoryService _genderCategoryService;
        private readonly IProductCategoryService _productCategoryService;
        public readonly IUnitOfWork _unitOfWork;
        public SearchController(IProductCategoryService productCategoryService, IUnitOfWork unitOfWork ,IGenderCategoryService genderCategoryService, IProductService productService, IProductImageService productImageService)
        {
            _productCategoryService = productCategoryService;
            _genderCategoryService = genderCategoryService;
            _productService = productService;
            _productImageService = productImageService;
            _unitOfWork = unitOfWork;
        }
        public async  Task<IActionResult> Index(int page = 1)
        {
            var product = await _productService.GetAllPaginatedAsync(page);

            var homeVM = new HomePaginatedVM()
            {
                //ProductImages = productImage
            };
       
            homeVM.Product = product;
            return View(homeVM);
        }
        [HttpGet]
        public async Task<IActionResult> Index(string productSearch)
        {
            ViewData["SearchedProduct"] = productSearch;
            var product = await _productService.GetAllAsync();
            //var productImage = await _productImageService.GetAllAsync();
            var productQuery = from p in await _unitOfWork.productRepository.GetAllAsync(p=>p.IsDeleted == false) select p;
            if (!String.IsNullOrEmpty(productSearch))
            {
                productQuery =
                    productQuery.Where(p => p.Name.Trim().ToLower().Contains(productSearch.Trim().ToLower()));
            }
            return View(productQuery.ToList());
        }
    }
}
