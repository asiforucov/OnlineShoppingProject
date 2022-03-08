using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace LifeStyle.Controllers
{
    public class ProductOperationController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public ProductOperationController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult Index()
        {
            return View();
        }
        //public async Task<IActionResult> Basket()
        //{
        //    var userId = _userManager.GetUserId(HttpContext.User);
        //    var products = await _productService.GetAllBasketAsync(userId);
        //    var productImages = await _productImageService.GetAllAsync();
        //    BasketViewModel basketViewModel = new BasketViewModel
        //    {
        //        Products = products,
        //        ProductOperations = productoperations,
        //        productImages = productImages
        //    }
        //    return View(basketViewModel);
        //}
    }
}
