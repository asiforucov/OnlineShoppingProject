using Business.Interfaces;
using Business.ViewModels.Product;
using Core;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
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
        public Task Create(ProductCreateViewModel productViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<Product> Get(int id)
        {
            return await _unitOfWork.productRepository.Get(p => p.Id == id);
        }

        public async Task<List<Product>> GetAllAsync()
        {
            return await _unitOfWork.productRepository.GetAllAsync(p=>p.IsDeleted==false);
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
