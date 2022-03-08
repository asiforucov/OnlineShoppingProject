using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.ProductImage;
using Core;
using Core.Entities;

namespace Business.Implementations
{
    public class ProductImageService : IProductImageService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductImageService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task Create(ProductImageCreateViewModel productImageViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductImage> Get(int id)
        {
            return await _unitOfWork.productImageRepository.Get(pi => pi.Id == id);
        }

        public async Task<List<ProductImage>> GetAllAsync()
        {
            return await _unitOfWork.productImageRepository.GetAllAsync();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, ProductImageUpdateViewModel productImageViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
