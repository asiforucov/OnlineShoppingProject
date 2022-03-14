using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.Comment;
using Business.ViewModels.ProductDetail;
using Core;

namespace LifeStyle.Controllers
{
    public class Product_detailController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IGenderCategoryService _genderCategoryService;
        private readonly IProductColorService _productColorService;
        private readonly IProductBrandService _productSizeService;

        public Product_detailController(IUnitOfWork unitOfWork, ICommentService commentService, IProductService productService, IProductCategoryService productCategoryService, IGenderCategoryService genderCategoryService, IProductColorService productColorService, IProductBrandService productSizeService)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _genderCategoryService = genderCategoryService;
            _productColorService = productColorService;
            _productSizeService = productSizeService;
            _commentService = commentService;
        }
        public async Task<IActionResult> Index(int id)
        {
            var dbProduct = await _productService.Get(id);
            var dbcomements = await _commentService.GetbyPid(id);
            var detailVM = new ProductDetailVM()
            {
                product = dbProduct,
                Comments = dbcomements
            };
            return View(detailVM);
        }

        [HttpPost]
        public async  Task<IActionResult> CreateComment(ProductDetailVM productDetailVm)
        {
             await _commentService.Create(productDetailVm);
             return RedirectToAction("Index","Home");
        }
    }
}
