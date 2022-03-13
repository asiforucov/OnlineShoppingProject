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
    public class ProductSizeService : IProductBrandService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductSizeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task Create(ProductBrandCreateViewModel productBrandViewModel)
        {
            var newBrand = new ProductBrand()
            {
                Name = productBrandViewModel.Name
            };
            await _unitOfWork.productSizeRepository.CreateAsync(newBrand);
            await _unitOfWork.SaveAsync();
        }

        public async Task<ProductBrand> Get(int id)
        {
            return await _unitOfWork.productSizeRepository.Get(ps => ps.Id == id);
        }

        public async Task<List<ProductBrand>> GetAllAsync()
        {
            return await _unitOfWork.productSizeRepository.GetAllAsync(s => s.IsDeleted == false);
        }

        public async Task Remove(int id)
        {
            ProductBrand dbCategory = await _unitOfWork.productSizeRepository.Get(b => b.Id == id);
            dbCategory.IsDeleted = true;
            await _unitOfWork.SaveAsync();
        }

        public async Task Update(int id, ProductBrandUpdateViewModel productBrandViewModel)
        {
            ProductBrand brand = await _unitOfWork.productSizeRepository.Get(b => b.Id == id);
            brand.Name = productBrandViewModel.Name;
            await _unitOfWork.SaveAsync();
        }
    }
}
