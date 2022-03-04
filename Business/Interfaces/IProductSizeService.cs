using Business.ViewModels.ProductSize;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IProductSizeService
    {
        Task<List<ProductSize>> GetAllAsync();
        Task Create(ProductSizeCreateViewModel productSizeViewModel);
        Task Update(int id, ProductSizeUpdateViewModel productSizetViewModel);
        Task Remove(int id);
    }
}
