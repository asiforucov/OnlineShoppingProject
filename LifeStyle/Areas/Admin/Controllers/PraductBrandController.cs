﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.ProductCategory;
using Business.ViewModels.ProductSize;
using Core;
using Core.Entities;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
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
            await _productBrandService.Create(model);
            return RedirectToAction(nameof(Index));
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


    }
}