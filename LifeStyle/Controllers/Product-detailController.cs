using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;

namespace LifeStyle.Controllers
{
    public class Product_detailController : Controller
    {
        private readonly IProductService _productService;

        public Product_detailController(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<IActionResult> Index(int id)
        {
            var product = await _productService.Get(id);
            return View(product);
        }
    }
}
