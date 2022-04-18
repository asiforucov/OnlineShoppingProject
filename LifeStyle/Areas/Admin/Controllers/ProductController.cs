using Business.Interfaces;
using Core;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Tools;
using Business.ViewModels.Product;
using Core.Entities;
using Microsoft.AspNetCore.Authorization;

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin, SuperAdmin")]
    public class ProductController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IProductService _productService;
        private readonly IProductCategoryService _productCategoryService;
        private readonly IGenderCategoryService _genderCategoryService;
        private readonly IProductColorService _productColorService;
        private readonly IProductBrandService _productBrandService;
        private readonly IProductImageService _productImageService;

        public ProductController(IUnitOfWork unitOfWork, IProductImageService productImageService, IProductService productService, IProductCategoryService productCategoryService, IGenderCategoryService genderCategoryService, IProductBrandService productBrandService)
        {
            _unitOfWork = unitOfWork;
            _productService = productService;
            _productCategoryService = productCategoryService;
            _genderCategoryService = genderCategoryService;
            _productBrandService = productBrandService;
            _productImageService = productImageService;
        }


        public async Task<ActionResult> Index(int page=1)
        {
            //var productCategories = await _productCategoryService.GetAllAsync();
            //var productImages = await _productImageService.GetAllAsync();
            //var product = await _unitOfWork.productRepository.GetAllAsync();
            //ProductHomeVM productHomeVM = new ProductHomeVM()
            //{
            //    ProductImages = productImages,
            //    ProductCategories = productCategories,
            //    Products = product
            //};
            var products = await _productService.GetAllPaginatedAsync(page);
            return View(products);
            //return View(productHomeVM);
        }


        public async Task<ActionResult> Create()
        {
            ViewBag.productCategory = await _productCategoryService.GetAllAsync();
            ViewBag.genderCategory = await _genderCategoryService.GetAllAsync();
            //ViewBag.color = await _productColorService.GetAllAsync();
            ViewBag.brand = await _productBrandService.GetAllAsync();

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProductCreateViewModel productViewModel)
        {

            ViewBag.productCategory = await _productCategoryService.GetAllAsync();
            ViewBag.genderCategory = await _genderCategoryService.GetAllAsync();
            ViewBag.brand = await _productBrandService.GetAllAsync();

            if (ModelState.IsValid)
            {
                foreach (var item in productViewModel.Photo)
                {
                    if (!item.CheckFileType("image/"))
                    {
                        ModelState.AddModelError("Photo", "Seçdiyiniz fayl şəkil tipində olmalıdır ! ");
                        return View(productViewModel);
                    }
                    if (!item.CheckFileSize(300))
                    {
                        ModelState.AddModelError("Photo", "Seçdiyiniz faylın ölçüsü 300 kb dan çox olmamalıdır !");
                        return View(productViewModel);
                    }
                }
                await _productService.Create(productViewModel);
                return RedirectToAction(nameof(Index));
            }
            return View(productViewModel);
        }


        public async Task<ActionResult> Update(int id)
        {

            ViewBag.productCategory = await _productCategoryService.GetAllAsync();
            ViewBag.genderCategory = await _genderCategoryService.GetAllAsync();
            ViewBag.brand = await _productBrandService.GetAllAsync();
            Product product = await _productService.Get(id);
            if (product == null) return NotFound();
            var productViewModel = new ProductUpdateViewModel()
            {
                Name = product.Name,
                Price = product.Price,
                Count = product.Count,
                Color = product.Color,
                GenderCategoryId = product.GenderCategoryId,
                ProductCategoryId = product.ProductCategoryId,
                ProductBrandId = product.ProductBrandId,
                Information = product.Description,
                Size = product.Size
            };
            return View(productViewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Update(int id, ProductUpdateViewModel productViewModel)
        {
            ViewBag.productCategory = await _productCategoryService.GetAllAsync();
            ViewBag.genderCategory = await _genderCategoryService.GetAllAsync();
            ViewBag.brand = await _productBrandService.GetAllAsync();

            if (ModelState.IsValid)
            {
                if (productViewModel.Photo != null)
                {
                    foreach (var item in productViewModel.Photo)
                    {

                        if (!item.CheckFileType("image/"))
                        {
                            ModelState.AddModelError("Photo", "Seçdiyiniz fayl şəkil tipində olmalıdır ! ");
                            return View(productViewModel);
                        }

                        if (!item.CheckFileSize(300))
                        {
                            ModelState.AddModelError("Photo", "Seçdiyiniz faylın ölçüsü 300 kb dan çox olmamalıdır !");
                            return View(productViewModel);
                        }

                    }

                }
                await _productService.Update(id, productViewModel);
                return RedirectToAction(nameof(Index));
            }


            return View(productViewModel);
        }

        public async Task<ActionResult> Delete(int id)
        {
            await _productService.Remove(id);

            return RedirectToAction(nameof(Index));
        }

        //[HttpGet]
        //public async Task<IActionResult> Index(string productSearch)
        //{
        //    ViewData["SearchedCategory"] = productSearch;

        //    var categoryQuery = from c in await _unitOfWork.productCategoryRepository.GetAllAsync() select c;

        //    if (!String.IsNullOrEmpty(productSearch))
        //    {
        //        categoryQuery = categoryQuery.Where(c => c.Name.Contains(productSearch));
        //    }

        //    return View(categoryQuery.ToList());
        //}

    }
}
