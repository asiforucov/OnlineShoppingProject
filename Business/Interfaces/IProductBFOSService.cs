using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Core.Entities;

namespace Business.Interfaces
{
    public interface IProductBFOSService
    {
        Task<List<ProductOperation>> GetAllAsync(string userId);
        Task<List<ProductOperation>> GetAllFavouriteAsync(string userId);
        Task<List<ProductOperation>> GetAllBasketAsync(string userId);
        Task<List<ProductOperation>> GetAllOrderedAsync(string userId);
        Task<List<ProductOperation>> GetAllSendAsync(string userId);
        Task<ProductOperation> Get(int id);
        Task SetFavourite(int id, string userid);
        Task SetBasket(int id, string userid);

        Task SetOrdered(int id, string userid);
        Task SetSend(int id, string userid);
    }
}
