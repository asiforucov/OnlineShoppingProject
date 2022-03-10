using Business.ViewModels.ProductSize;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IProductBrandService
    {
        Task<List<ProductBrand>> GetAllAsync();
        Task<ProductBrand> Get(int id);

        Task Create(ProductBrandCreateViewModel productSBrandViewModel);
        Task Update(int id, ProductBrandUpdateViewModel productSBrandViewModel);
        Task Remove(int id);
    }
}
