using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.ProductCategory;
using Business.ViewModels.ProductSize;
using Core;
using Core.Entities;
using Microsoft.AspNetCore.Authorization;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class PraductBrandController : Controller
    {
        private readonly IProductBrandService _productBrandService;
        private readonly IUnitOfWork _unitOfWork;

        public PraductBrandController(IProductBrandService productBrandService, IUnitOfWork unitOfWork)
        {
            _productBrandService = productBrandService;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.productSizeRepository.GetAllAsync(b => b.IsDeleted == false));
        }
        public async Task<IActionResult> Delete(int id)
        {
            await _productBrandService.Remove(id);
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductBrandCreateViewModel model)
        {
            if (ModelState.IsValid)
            {
                await _productBrandService.Create(model);
                return RedirectToAction(nameof(Index));
            }

            return View(model);
        }
        public async Task<ActionResult> Update(int id)
        {
            ProductBrand category = await _productBrandService.Get(id);
            if (category == null) return NotFound();
            var categoryViewModel = new ProductBrandUpdateViewModel()
            {
                Name = category.Name
            };
            return View(categoryViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Update(int id, ProductBrandUpdateViewModel model)
        {
            await _productBrandService.Update(id, model);
            return RedirectToAction(nameof(Index));
        }
        //[HttpGet]
        //public async Task<IActionResult> Index(string brandSearch)
        //{
        //    ViewData["SearchedCategory"] = brandSearch;

        //    var categoryQuery = from c in await _unitOfWork.genderCategoryRepository.GetAllAsync() select c;

        //    if (!String.IsNullOrEmpty(brandSearch))
        //    {
        //        categoryQuery = categoryQuery.Where(c => c.Name.Contains(brandSearch));
        //    }

        //    return View(categoryQuery.ToList());
        //}

    }
}
