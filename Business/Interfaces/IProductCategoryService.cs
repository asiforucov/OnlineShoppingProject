using Business.ViewModels.ProductCategory;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
     public interface IProductCategoryService
    {
        Task<List<ProductCategory>> GetAllAsync();
        Task<ProductCategory> Get(int id);

        Task Create(ProductCategoryCreateViewModel productCategoryViewModel);
        Task Update(int id, ProductCategoryUpdateViewModel productCategoryViewModel);
        Task Remove(int id);
    }
}
