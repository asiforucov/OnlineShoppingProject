using Business.ViewModels.ProductColor;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IProductColorService
    {
        Task<List<ProductColor>> GetAllAsync();
        Task<ProductColor> Get(int id);

        Task Create(ProductColorCreateViewModel productColorViewModel);
        Task Update(int id, ProductColorUpdateViewModel productColorViewModel);
        Task Remove(int id);
    }
}
