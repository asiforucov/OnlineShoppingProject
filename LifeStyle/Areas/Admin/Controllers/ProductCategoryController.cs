using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.ProductCategory;
using Core;
using Core.Entities;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductCategoryController : Controller
    {
        private readonly IProductCategoryService _productCategoryService;
        private readonly IUnitOfWork _unitOfWork;

        public ProductCategoryController(IProductCategoryService productCategoryService, IUnitOfWork unitOfWork)
        {
            _productCategoryService = productCategoryService;
            _unitOfWork = unitOfWork;
        }
        public async Task<IActionResult> Index()
        {
            return View(await _unitOfWork.productCategoryRepository.GetAllAsync(pc => pc.IsDeleted == false));
        }

        public async Task<IActionResult> Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ProductCategoryCreateViewModel model)
        {
            await _productCategoryService.Create(model);
            return RedirectToAction(nameof(Index));
        }


        public async Task<IActionResult> Delete(int id)
        {
            await _productCategoryService.Remove(id);
            return RedirectToAction(nameof(Index));
        }


        public async Task<ActionResult> Update(int id)
        {
            ProductCategory category = await _productCategoryService.Get(id);
            if (category == null) return NotFound();
            var categoryViewModel = new ProductCategoryUpdateViewModel()
            {
                Name = category.Name
            };
            return View(categoryViewModel);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Update(int id, ProductCategoryUpdateViewModel model)
        {
            await _productCategoryService.Update(id, model);
            return RedirectToAction(nameof(Index));
        }
        [HttpGet]
        public async Task<IActionResult> Index(string categorySearch)
        {
            ViewData["SearchedCategory"] = categorySearch;

            var categoryQuery = from c in await _unitOfWork.productCategoryRepository.GetAllAsync() select c;

            if (!String.IsNullOrEmpty(categorySearch))
            {
                categoryQuery = categoryQuery.Where(c => c.Name.Contains(categorySearch));
            }

            return View(categoryQuery.ToList());
        }
    }
}
