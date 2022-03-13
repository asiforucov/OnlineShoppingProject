using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class Product_detail_adminController : Controller
    {
        private readonly IProductService _productService;
        private readonly IProductImageService _productImageService;

        public Product_detail_adminController(IProductService productService, IProductImageService productImageService)
        {
            _productService = productService;
            _productImageService = productImageService;
        }
        public async Task<IActionResult> Index(int id)
        {
            var product = await _productService.Get(id);
            return View(product);
        }
    }
}
