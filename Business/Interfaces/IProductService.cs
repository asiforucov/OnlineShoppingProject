
using Business.ViewModels.Product;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> Get(int id);

        Task Create(ProductCreateViewModel productViewModel);
        Task Update(int id, ProductUpdateViewModel productViewModel);
        Task Remove(int id);
    }
}
