using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.Product;
using Core;
using Microsoft.AspNetCore.Authorization;

namespace LifeStyle.Areas.Superadmin.Controllers
{
    [Area("Superadmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class Deleted_ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IGenderCategoryService _genderCategoryService;
        private readonly IProductColorService _productColorService;
        private readonly IProductBrandService _productBrandService;
        private readonly IProductImageService _productImageService;

        public Deleted_ProductController(IUnitOfWork unitOfWork, IProductImageService productImageService, IProductService productService, IProductCategoryService productCategoryService, IGenderCategoryService genderCategoryService, IProductBrandService productBrandService)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _genderCategoryService = genderCategoryService;
            _productBrandService = productBrandService;
            _productImageService = productImageService;
        }
        public async Task<IActionResult> Index()
        {
            var productCategories = await _productCategoryService.GetAllAsync();
            var productImages = await _productImageService.GetAllAsync();
            var product = await _unitOfWork.productRepository.GetAllAsync(p=>p.IsDeleted == true);
            ProductHomeVM productHomeVM = new ProductHomeVM()
            {
                ProductImages = productImages,
                ProductCategories = productCategories,
                Products = product
            };
            return View(productHomeVM);
        }
    }
}
