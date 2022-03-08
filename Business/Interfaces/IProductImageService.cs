using Business.ViewModels.ProductImage;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IProductImageService
    {
        Task<List<ProductImage>> GetAllAsync();
        Task<ProductImage> Get(int id);

        Task Create(ProductImageCreateViewModel productImageViewModel);
        Task Update(int id, ProductImageUpdateViewModel productImageViewModel);
        Task Remove(int id);
    }
}
