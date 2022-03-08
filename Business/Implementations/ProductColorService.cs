using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.ProductColor;
using Core;
using Core.Entities;

namespace Business.Implementations
{
    public class ProductColorService : IProductColorService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductColorService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task Create(ProductColorCreateViewModel productColorViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<ProductColor> Get(int id)
        {
            return await _unitOfWork.productColorRepository.Get(pc => pc.Id == id);
        }

        public async Task<List<ProductColor>> GetAllAsync()
        {
            return await _unitOfWork.productColorRepository.GetAllAsync(c => c.IsDeleted == false);
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, ProductColorUpdateViewModel productColorViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
