using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core;
using Microsoft.AspNetCore.Authorization;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class DashboardController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IGenderCategoryService _genderCategoryService;
        private readonly IProductColorService _productColorService;
        private readonly IProductBrandService _productSizeService;

        public DashboardController(IUnitOfWork unitOfWork, ICommentService commentService, IProductService productService, IProductCategoryService productCategoryService, IGenderCategoryService genderCategoryService, IProductColorService productColorService, IProductBrandService productSizeService)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _genderCategoryService = genderCategoryService;
            _productColorService = productColorService;
            _productSizeService = productSizeService;
            _commentService = commentService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetProduct()
        {
            var product = await _unitOfWork.productRepository.GetAllAsync(p => p.IsDeleted == false);
            ViewBag.productCount = product.Count;
           
            return View();
        } 
        public async Task<IActionResult> GetOrder()
        {
            return View();
        } 
        public async Task<IActionResult> GetUser()
        {
            return View();
        }
    }
}
