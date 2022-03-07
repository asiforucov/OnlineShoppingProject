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
        public Task Create(ProductCategoryCreateViewModel productCategoryViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductCategory>> GetAllAsync()
        {
            return await _unitOfWork.productCategoryRepository.GetAllAsync();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, ProductCategoryUpdateViewModel productCategoryViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
