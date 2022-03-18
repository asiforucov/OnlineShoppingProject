using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Core.Entities;
using Data.DAL;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class OrderedController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IProductBFOSService _productBFOSService;
        private readonly IProductImageService _productImageService;
        private readonly IProductService _productService;
        private readonly AppDbContext _context;


        public OrderedController(AppDbContext context, UserManager<ApplicationUser> userManager, IProductBFOSService productBFOSService, IProductImageService productImageService, IProductService productService)
        {
            _userManager = userManager;
            _productImageService = productImageService;
            _productBFOSService = productBFOSService;
            _productService = productService;
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var orders = await _context.Orders.ToListAsync();
            return View(orders);
        }
    }
}
