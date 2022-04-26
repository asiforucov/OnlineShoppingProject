using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels;
using Business.ViewModels.Stat;
using Core;
using Core.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

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
        private readonly IOrderService _orderService;
        private readonly UserManager<ApplicationUser> _userManager;


        public DashboardController(UserManager<ApplicationUser> userManager, IOrderService orderService, IUnitOfWork unitOfWork, ICommentService commentService, IProductService productService, IProductCategoryService productCategoryService, IGenderCategoryService genderCategoryService, IProductColorService productColorService, IProductBrandService productSizeService)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _genderCategoryService = genderCategoryService;
            _productColorService = productColorService;
            _productSizeService = productSizeService;
            _commentService = commentService;
            _orderService = orderService;
            _userManager = userManager;


        }
        public async Task<IActionResult> Index()
        {
            var orders = await _orderService.GetAllAsync();
            var products = await _productService.GetAllAsync();
            var users = await _userManager.Users.ToListAsync();


            var stats = new StatVM
            {
                OrderCount = orders.Count,
                ProductCount = products.Count,
                UserCount = users.Count
            };
            return View(stats);
        }

        //public async Task<IActionResult> GetProduct()
        //{

        //    var product = await _unitOfWork.productRepository.GetAllAsync(p => p.IsDeleted == false);
        //    var dashboardVM = new DashboardVM()
        //    {
        //        ProductCount = product.Count
        //    };

        //    return View(dashboardVM);
        //} 
        //public async Task<IActionResult> GetOrder()
        //{
        //    return View();
        //} 
        //public async Task<IActionResult> GetUser()
        //{
        //    return View();
        //}
    }
}
