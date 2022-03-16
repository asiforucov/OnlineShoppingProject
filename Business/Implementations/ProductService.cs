using Business.Interfaces;
using Business.ViewModels.Product;
using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Tools;
using Microsoft.AspNetCore.Hosting;
using Business.ViewModels.Paginate;

namespace Business.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;
        public ProductService(IUnitOfWork unitOfWork, IWebHostEnvironment env)
        {
            _unitOfWork = unitOfWork;
            _env = env;
        }
        public async Task Create(ProductCreateViewModel productViewModel)
        {
            var newProduct = new Product()
            {
                Name = productViewModel.Name,
                Price = productViewModel.Price,
                Description = productViewModel.Information,
                Count = productViewModel.Count,
                ProductBrandId = productViewModel.ProductBrandId,
                GenderCategoryId = productViewModel.GenderCategoryId,
                ProductCategoryId = productViewModel.ProductCategoryId,
                Size = productViewModel.Size,
                Color = productViewModel.Color

            };
            await _unitOfWork.productRepository.CreateAsync(newProduct);
            await _unitOfWork.SaveAsync();
            var products = await _unitOfWork.productRepository.GetAllAsync();
            var readyProduct = products[products.Count - 1];
            for (int i = 0; i < productViewModel.Photo.Count; i++)
            {
                string filename = await productViewModel.Photo[i].SaveFileAsync(_env.WebRootPath, "assets", "image");
                var productImage = new ProductImage()
                {
                    Image = filename,
                    ProductId = readyProduct.Id
                };
                await _unitOfWork.productImageRepository.CreateAsync(productImage);
                if (i == 0)
                {
                    productImage.IsMain = true;
                }
            }
            await _unitOfWork.SaveAsync();
        }
        public async Task<Product> Get(int id)
        {
            return await _unitOfWork.productRepository
                .Get(p => p.Id == id && p.IsDeleted == false, "ProductCategory", "GenderCategory", "ProductBrand", "ProductImages");
        }
        public async Task<List<Product>> GetAllAsync()
        {
            var getall = await _unitOfWork.productRepository.GetAllAsync(p => p.IsDeleted == false, "ProductCategory", "GenderCategory", "ProductBrand", "ProductImages");
            return getall;
        }

        public async Task<Paginate<Product>> GetAllPaginatedAsync(int page)
        {
            var products = await _unitOfWork
                .productRepository
                .GetAllPaginatedAsync(page, 10, p => p.IsDeleted == false && p.ProductCategory.IsDeleted == false,
                    "ProductCategory");

            var Result = new Paginate<Product>
            {
                AllPageCount = await getPageCount(8),
                CurrentPage = page,
                Items = products,
            };
            return Result;
        }

        public async Task<int> getPageCount(int take)
        {
            var products = await _unitOfWork
                .productRepository
                .GetAllAsync(p => p.IsDeleted == false && p.ProductCategory.IsDeleted == false,
                    "ProductCategory");
            var productCount = products.Count;
            return (int)Math.Ceiling(((decimal)productCount / take));
        }

        public async Task Remove(int id)
        {
            var deleted = await _unitOfWork.productRepository.Get(p => p.Id == id && p.IsDeleted == false, "ProductCategory");
            deleted.IsDeleted = true;
            await _unitOfWork.SaveAsync();
        }

        public async Task Update(int id, ProductUpdateViewModel productViewModel)
        {

            Product dbProduct = await _unitOfWork.productRepository.Get(p => p.Id == id);

            dbProduct.Name = productViewModel.Name;
            dbProduct.Price = productViewModel.Price;
            dbProduct.Count = productViewModel.Count;
            dbProduct.Color = productViewModel.Color;
            dbProduct.GenderCategoryId = productViewModel.GenderCategoryId;
            dbProduct.ProductCategoryId = productViewModel.ProductCategoryId;
            dbProduct.ProductBrandId = productViewModel.ProductBrandId;
            dbProduct.Description = productViewModel.Information;
            dbProduct.Size = productViewModel.Size;
            await _unitOfWork.SaveAsync();

            if (productViewModel.Photo != null)
            {
                for (int i = 0; i < productViewModel.Photo.Count; i++)
                {
                    string filename = await productViewModel.Photo[i].SaveFileAsync(_env.WebRootPath, "assets", "image");
                    var productImage = new ProductImage()
                    {
                        Image = filename,
                        ProductId = id

                    };
                    await _unitOfWork.productImageRepository.CreateAsync(productImage);
                }
            }
            await _unitOfWork.SaveAsync();

        }
    }
}
