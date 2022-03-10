using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeStyle.Controllers
{
    public class Product_detailController : Controller
    {
        public IActionResult Index(int id)
        {
            return View();
        }
    }
}
