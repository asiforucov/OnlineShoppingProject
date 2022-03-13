using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.GenderCategory;
using Core;
using Core.Entities;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class GenderController : Controller
    {
        private readonly IGenderCategoryService _genderCategoryService;
        private readonly IUnitOfWork _unitOfWork;

        public GenderController(IGenderCategoryService genderCategoryService, IUnitOfWork unitOfWork)
        {
            _genderCategoryService = genderCategoryService;
            _unitOfWork = unitOfWork;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.genderCategoryRepository.GetAllAsync(gc => gc.IsDeleted == false));
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(GenderCategoryCreateViewModel model)
        {
            await _genderCategoryService.Create(model);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            await _genderCategoryService.Remove(id);
            return RedirectToAction(nameof(Index));
        }


        public async Task<ActionResult> Update(int id)
        {
            GenderCategory gender = await _genderCategoryService.Get(id);
            if (gender == null) return NotFound();
            var genderViewModel = new GenderCategoryUpdateViewModel()
            {
                Name = gender.Name
            };
            return View(genderViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Update(int id, GenderCategoryUpdateViewModel model)
        {
            await _genderCategoryService.Update(id, model);
            return RedirectToAction(nameof(Index));
        }
    }
}
