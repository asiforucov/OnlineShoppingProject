﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeStyle.Controllers
{
    public class Error_404Controller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}