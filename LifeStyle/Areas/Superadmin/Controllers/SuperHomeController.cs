using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeStyle.Areas.Superadmin.Controllers
{
    [Area("Superadmin")]
    public class SuperHomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
