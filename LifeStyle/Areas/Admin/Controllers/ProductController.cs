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

namespace LifeStyle.Areas.Admin.Controllers
{
    [Area("Admin")]
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


        public async Task<ActionResult> Index()
        {
            var productCategories = await _productCategoryService.GetAllAsync();
            var productImages = await _productImageService.GetAllAsync();
            var product = await _unitOfWork.productRepository.GetAllAsync();
            ProductHomeVM productHomeVM = new ProductHomeVM()
            {
                ProductImages = productImages,
                ProductCategories = productCategories,
                Products = product
            };
            return View(productHomeVM);
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


        //public async Task<ActionResult> Update(int id)
        //{
        //    ViewBag.categories = await _categoryService.GetAllAsync();
        //    ViewBag.brands = await _brandService.GetAllAsync();

        //    Product product = await _productService.Get(id);

        //    if (product == null) return NotFound();


        //    var productViewModel = new ProductUpdateViewModel()
        //    {
        //        Name = product.Name,
        //        Description = product.Description,
        //        Information = product.Information,
        //        Price = product.Price,
        //        Count = product.Count,
        //        DiscountPrice = product.DiscountPrice,
        //        CategoryId = product.CategoryId,
        //        IsDiscount = product.IsDiscount,
        //        BrandId = product.BrandId

        //    };



        //    return View(productViewModel);
        //}

        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<ActionResult> Update(int id, ProductUpdateViewModel productViewModel)
        //{
        //    ViewBag.categories = await _categoryService.GetAllAsync();
        //    ViewBag.brands = await _brandService.GetAllAsync();

        //    if (ModelState.IsValid)
        //    {
        //        if (productViewModel.ImageFiles != null)
        //        {
        //            foreach (var item in productViewModel.ImageFiles)
        //            {

        //                if (!item.CheckFileType("image/"))
        //                {
        //                    ModelState.AddModelError("ImageFiles", "Seçdiyiniz fayl şəkil tipində olmalıdır ! ");
        //                    return View(productViewModel);
        //                }

        //                if (!item.CheckFileSize(300))
        //                {
        //                    ModelState.AddModelError("ImageFiles", "Seçdiyiniz faylın ölçüsü 300 kb dan çox olmamalıdır !");
        //                    return View(productViewModel);
        //                }

        //            }

        //        }
        //        await _productService.Update(id, productViewModel);
        //        return RedirectToAction(nameof(Index));
        //    }


        //    return View(productViewModel);
        //}

        //public async Task<ActionResult> Delete(int id)
        //{
        //    await _productService.Remove(id);

        //    return RedirectToAction(nameof(Index));
        //}



    }
}
