using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.Product;
using Core;

namespace LifeStyle.Areas.Superadmin.Controllers
{
    [Area("Superadmin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IGenderCategoryService _genderCategoryService;
        private readonly IProductColorService _productColorService;
        private readonly IProductBrandService _productBrandService;
        private readonly IProductImageService _productImageService;

        public ProductController(IUnitOfWork unitOfWork, IProductImageService productImageService, IProductService productService, IProductCategoryService productCategoryService, IGenderCategoryService genderCategoryService, IProductBrandService productBrandService)
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
            var product = await _unitOfWork.productRepository.GetAllAsync();
            ProductHomeVM productHomeVM = new ProductHomeVM()
            {
                ProductImages = productImages,
                ProductCategories = productCategories,
                Products = product
            };
            return View(productHomeVM);
        }

        public async Task<IActionResult> GetAll()
        {
            var productCategories = await _productCategoryService.GetAllAsync();
            var productImages = await _productImageService.GetAllAsync();
            var product = await _unitOfWork.productRepository.GetAllAsync();
            ProductHomeVM productHomeVM = new ProductHomeVM()
            {
                ProductImages = productImages,
                ProductCategories = productCategories,
                Products = product
            };
            return View(productHomeVM);
        } 
        public async Task<IActionResult> GetDeleted()
        {
            var productCategories = await _productCategoryService.GetAllAsync();
            var productImages = await _productImageService.GetAllAsync();
            var product = await _unitOfWork.productRepository.GetAllAsync();
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
