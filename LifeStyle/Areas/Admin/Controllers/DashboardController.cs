using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> GetProduct()
        {
            return View();
        }
    }
}
