using Business.Interfaces;
using Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ISliderService _sliderService;
        private readonly IUnitOfWork _unitOfWork;
        public SliderController(ISliderService sliderService, IUnitOfWork unitOfWork)
        {
            _sliderService = sliderService;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.sliderRepository.GetAllAsync());
        }
    }
}
