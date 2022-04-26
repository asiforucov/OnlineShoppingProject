using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace LifeStyle.Areas.Superadmin.Controllers
{
    [Area("Superadmin")]
    [Authorize(Roles = "SuperAdmin")]
    public class SuperHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
