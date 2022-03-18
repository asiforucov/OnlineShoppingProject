using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Implementations;
using Business.Interfaces;
using Business.ViewModels.ProductBFOS;
using Core.Entities;
using Data.DAL;
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
        private readonly AppDbContext _context;


        public ProductBFOSController(AppDbContext context, UserManager<ApplicationUser> userManager, IProductBFOSService productBFOSService, IProductImageService productImageService, IProductService productService)
        {
            _userManager = userManager;
            _productImageService = productImageService;
            _productBFOSService = productBFOSService;
            _productService = productService;
            _context = context;
        }
        [Authorize]
        public async Task<IActionResult> SetFavorite(int id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            await _productBFOSService.SetFavourite(id, userId);
            return RedirectToAction("Favorite", "ProductBFOS");
        }
        [Authorize]
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
        [Authorize]
        public async Task<IActionResult> SetBasket(int id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            await _productBFOSService.SetBasket(id, userId);
            return RedirectToAction("Basket", "ProductBFOS");
        }
        [Authorize]
        public async Task<IActionResult> Basket()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var products = await _productService.GetAllAsync();
            var productOperations = await _productBFOSService.GetAllBasketAsync(userId);
            var productImages = await _productImageService.GetAllAsync();
            BasketVM basketVM = new BasketVM
            {
                Products = products,
                ProductOperations = productOperations,
                ProductImages = productImages
            };
            return View(basketVM);
        }
        [Authorize]
        public async Task<IActionResult> DeleteBasket(int id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            await _productBFOSService.DeleteBasket(id, userId);
            return RedirectToAction("Basket");
        }
        [Authorize]
        public async Task<IActionResult> DeleteFavorite(int id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            await _productBFOSService.DeleteFavorite(id, userId);
            return RedirectToAction("Favorite");
        }

        [Authorize]
        public async Task<IActionResult> SetOrdered(int id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            await _productBFOSService.SetOrdered(id, userId);

            return RedirectToAction("SuccesOrdered");
        }
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            await _productBFOSService.DeleteOrdered(id, userId);
            return RedirectToAction("Ordered");
        }

        public IActionResult SuccesOrdered()
        {
            return View();
        }

        public async Task<IActionResult> Pay(int pid, string userid)
        {
            await _productBFOSService.SetOrdered(userid);
            ViewBag.Userid = userid;
            ViewBag.Pid =pid;
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Pay(OrderVM orderVm)
        {
            //orderVm.ApplicationUserId = "1e2d0c37-6522-422d-b344-dcb6b6e2b4e7";
            var order = new Order()
            {
                Name = orderVm.Name,
                PhoneNumber = orderVm.PhoneNumber,
                Size = orderVm.Size,
                Color = orderVm.Color,
                PostalCode = orderVm.PostalCode,
                Adress = orderVm.Adress,
                City = orderVm.City,
                ApplicationUserId = orderVm.ApplicationUserId,
                Surname = orderVm.Surname,
                ProductId = orderVm.ProductId
            };
            await _context.Orders.AddAsync(order);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(SuccesOrdered));
        }
        [Authorize]
        public async Task<IActionResult> Ordered()
        {
            var userId = _userManager.GetUserId(HttpContext.User);
            var products = await _productService.GetAllAsync();
            var productOperations = await _productBFOSService.GetAllOrderedAsync(userId);
            BasketVM basketVM = new BasketVM
            {
                Products = products,
                ProductOperations = productOperations,
            };
            return View(basketVM);
        }
    }
}
