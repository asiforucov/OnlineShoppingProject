using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.ProductSize;
using Core;
using Core.Entities;

namespace Business.Implementations
{
    public class ProductSizeService : IProductSizeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductSizeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task Create(ProductSizeCreateViewModel productSizeViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductSize> Get(int id)
        {
            return await _unitOfWork.productSizeRepository.Get(ps => ps.Id == id);
        }

        public async Task<List<ProductSize>> GetAllAsync()
        {
            return await _unitOfWork.productSizeRepository.GetAllAsync(s => s.IsDeleted == false);
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, ProductSizeUpdateViewModel productSizetViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
