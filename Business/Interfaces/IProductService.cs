
using Business.ViewModels.Product;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.ViewModels.Paginate;

namespace Business.Interfaces
{
    public interface IProductService
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> Get(int id);
        Task<Paginate<Product>> GetAllPaginatedAsync(int page);
        Task<int> getPageCount(int take);
        Task Create(ProductCreateViewModel productViewModel);
        Task Update(int id, ProductUpdateViewModel productViewModel);
        Task Remove(int id);
    }
}
