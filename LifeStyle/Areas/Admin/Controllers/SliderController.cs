using Business.Interfaces;
using Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.ViewModels.Slider;
using Business.Tools;

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

        public async Task<IActionResult> Delete(int id)
        {
            await _sliderService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
        [HttpPost]
        public async Task<IActionResult> Create(SliderCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                if (!model.Photo.CheckFileType("image/"))
                {
                    ModelState.AddModelError("Photo", "file  should be  image type ");
                    return View(model);
                }

                if (!model.Photo.CheckFileSize(400))
                {
                    ModelState.AddModelError("Photo", "file size must be less than 200kb");
                    return View(model);
                }

                await _sliderService.Create(model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        } 
        public async Task<IActionResult> Update()
        {
            return RedirectToAction(nameof(Index));
        } 
        [HttpPost]
        public async Task<IActionResult> Update(int id)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
