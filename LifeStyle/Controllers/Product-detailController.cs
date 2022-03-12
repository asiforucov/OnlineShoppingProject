using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core;

namespace LifeStyle.Controllers
{
    public class Product_detailController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IGenderCategoryService _genderCategoryService;
        private readonly IProductColorService _productColorService;
        private readonly IProductBrandService _productSizeService;

        public Product_detailController(IUnitOfWork unitOfWork, IProductService productService, IProductCategoryService productCategoryService, IGenderCategoryService genderCategoryService, IProductColorService productColorService, IProductBrandService productSizeService)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _genderCategoryService = genderCategoryService;
            _productColorService = productColorService;
            _productSizeService = productSizeService;
        }
        public async Task<IActionResult> Index(int id)
        {
            var product = await _productService.Get(id);
            return View(product);
        }
    }
}
