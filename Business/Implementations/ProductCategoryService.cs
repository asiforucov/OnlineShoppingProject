using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.ProductCategory;
using Core;
using Core.Entities;

namespace Business.Implementations
{
    public class ProductCategoryService : IProductCategoryService
    {

        private readonly IUnitOfWork _unitOfWork;
        public ProductCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<ProductCategory> Get(int id)
        {
            return await _unitOfWork.productCategoryRepository.Get(pc => pc.Id == id);
        }

        public async Task<List<ProductCategory>> GetAllAsync()
        {
            return await _unitOfWork.productCategoryRepository.GetAllAsync();
        }

        public async Task Create(ProductCategoryCreateViewModel model)
        {
            var newCategory = new ProductCategory()
            {
                Name = model.Name
            };
            await _unitOfWork.productCategoryRepository.CreateAsync(newCategory);
            await _unitOfWork.SaveAsync();
        }

        public async Task Update(int id, ProductCategoryUpdateViewModel model)
        {
            ProductCategory dbCategory = await _unitOfWork.productCategoryRepository.Get(b => b.Id == id);
            dbCategory.Name = model.Name;
            await _unitOfWork.SaveAsync();
        }

        public async Task Remove(int id)
        {
            ProductCategory dbCategory = await _unitOfWork.productCategoryRepository.Get(b => b.Id == id);
            dbCategory.IsDeleted = true;
            await _unitOfWork.SaveAsync();

        }
    }
}
