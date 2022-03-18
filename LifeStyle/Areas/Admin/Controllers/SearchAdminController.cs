using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.Home;
using Core;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SearchAdminController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IGenderCategoryService _genderCategoryService;
        private readonly IProductColorService _productColorService;
        private readonly IProductBrandService _productBrandService;
        private readonly IProductImageService _productImageService;

        public SearchAdminController(IUnitOfWork unitOfWork, IProductImageService productImageService, IProductService productService, IProductCategoryService productCategoryService, IGenderCategoryService genderCategoryService, IProductBrandService productBrandService)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _genderCategoryService = genderCategoryService;
            _productBrandService = productBrandService;
            _productImageService = productImageService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> Index(string productSearch,int page =1)
        {
            ViewData["SearchedProduct"] = productSearch;
            var products = await _productService.GetAllPaginatedAsync(page);
            var productQuery = from p in await _unitOfWork.productRepository.GetAllAsync() select p;
            if (!String.IsNullOrEmpty(productSearch))
            {
                productQuery =
                    productQuery.Where(p => p.Name.Trim().ToLower().Contains(productSearch.Trim().ToLower()));
            }
            var homeVM = new HomePaginatedVM()
            {

                //Product = productQuery.t
            };
            return View(homeVM);
        }
    }
}
