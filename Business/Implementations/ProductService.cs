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
                .Get(p => p.Id == id, "ProductCategory", "GenderCategory", "ProductBrand", "ProductImages");
        }
        public async Task<List<Product>> GetAllAsync()
        {
            var getall = await _unitOfWork.productRepository.GetAllAsync(p => p.IsDeleted == false, "ProductCategory");
            return getall;
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, ProductUpdateViewModel productViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
