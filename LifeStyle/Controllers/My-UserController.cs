using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core;
using Core.Entities;
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
        public My_UserController(UserManager<ApplicationUser> userManager,
            SignInManager
                <ApplicationUser> signInManager, IUnitOfWork unitOfWork)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index(string userId)
        {
            ViewBag.userId = userId;
            var userid = _userManager.FindByIdAsync(userId);
            //ViewBag.userName = user.userName
            return View(userid);
        }
    }
}
