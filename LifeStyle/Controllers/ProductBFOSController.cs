using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Implementations;
using Business.Interfaces;
using Business.ViewModels.ProductBFOS;
using Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace LifeStyle.Controllers
{
    public class ProductBFOSController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IProductBFOSService _productBFOSService;
        private readonly IProductImageService _productImageService;
        private readonly IProductService _productService;


        public ProductBFOSController(UserManager<ApplicationUser> userManager, IProductBFOSService productBFOSService, IProductImageService productImageService, IProductService productService)
        {
            _userManager = userManager;
            _productImageService = productImageService;
            _productBFOSService = productBFOSService;
            _productService = productService;
        }
        [Authorize]
        public async Task<IActionResult> SetFavorite(int id)
        {

            var userId = _userManager.GetUserId(HttpContext.User);

            await _productBFOSService.SetFavourite(id, userId);


            return RedirectToAction("Index", "Home");
        }
        //[Authorize]
        public async Task<IActionResult> Favorite()
        {

            var userId = _userManager.GetUserId(HttpContext.User);

            var products = await _productService.GetAllAsync();
            var productOperations = await _productBFOSService.GetAllFavouriteAsync(userId);
            var productImages = await _productImageService.GetAllAsync();

            FavoriteVM favoriteVM = new FavoriteVM
            {
                Products = products,
                ProductOperations = productOperations,
                ProductImages = productImages
            };


            return View(favoriteVM);
        }
    }
}
