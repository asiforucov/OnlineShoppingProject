using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.My_User;
using Core;
using Core.Entities;
using Data.DAL;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;

namespace LifeStyle.Controllers
{
    [Authorize]
    public class My_UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;
        public readonly IUnitOfWork _unitOfWork;
        private readonly IProductBFOSService _productBFOSService;
        private readonly AppDbContext _context;
        private readonly IProductService _productService;
        public My_UserController(UserManager<ApplicationUser> userManager,
            SignInManager
                <ApplicationUser> signInManager, IProductBFOSService productBFOSService, IUnitOfWork unitOfWork, IProductService productService, AppDbContext context)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
            _productService = productService;
            _context = context;
            _productBFOSService = productBFOSService;
        }
        public async Task<IActionResult> Index()
        {
            ApplicationUser appUser = await _userManager.GetUserAsync(HttpContext.User);

            var my_UserVm = new My_UserVM()
            {
                Email = appUser.Email,
                PhoneNumber = appUser.PhoneNumber,
                FullName = appUser.FullName,
                Products = await _productService.GetAllAsync(),
                ProductOperations = await _productBFOSService.GetAllOrderedAsync(appUser.Id)

            };


            //var userEmail = appUser.Email;
            //var userPhoneNumber = appUser.PhoneNumber;
            //var userFullName = appUser.FullName;
            //var userName = appUser.UserName;

            //ViewBag.userId = userId;
            //var userid = _userManager.FindByIdAsync(userId);
            return View(my_UserVm);
        }
    }
}
