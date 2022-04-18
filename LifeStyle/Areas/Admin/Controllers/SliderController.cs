using Business.Interfaces;
using Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.ViewModels.Slider;
using Business.Tools;
using Business.ViewModels.Product;
using Core.Entities;
using Microsoft.AspNetCore.Authorization;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, SuperAdmin")]
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

        public async Task<IActionResult> Update(int id)
        {
            Slider slider = await _sliderService.Get(id);
            if (slider == null) return NotFound();
            var sliderViewModel = new SliderUpdateViewModel()
            {
                Name = slider.Name,
                Title = slider.Title
            };
            return View(sliderViewModel);
        } 
        [HttpPost]
        public async Task<IActionResult> Update(SliderUpdateViewModel model,int id)
        {
            if (ModelState.IsValid)
            {
                if (model.Photo != null)
                {
                        if (!model.Photo.CheckFileType("image/"))
                        {
                            ModelState.AddModelError("ImageFiles", "Seçdiyiniz fayl şəkil tipində olmalıdır ! ");
                            return View(model);
                        }

                        if (!model.Photo.CheckFileSize(300))
                        {
                            ModelState.AddModelError("ImageFiles", "Seçdiyiniz faylın ölçüsü 300 kb dan çox olmamalıdır !");
                            return View(model);
                        }
                }
                await _sliderService.Update(id, model);
                return RedirectToAction(nameof(Index));
            }
            return View(model);

        }
    }
}
