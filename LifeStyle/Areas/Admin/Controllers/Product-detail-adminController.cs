using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.ProductDetail;
using Microsoft.AspNetCore.Authorization;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class Product_detail_adminController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICommentService _commentService;
        private readonly IProductImageService _productImageService;

        public Product_detail_adminController(IProductService productService, IProductImageService productImageService, ICommentService commentService)
        {
            _productService = productService;
            _productImageService = productImageService;
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
        public async Task<IActionResult> Delete(int id)
        {
            await _commentService.Remove(id);
            return RedirectToAction("Index", "Product");
        }


    }
}
