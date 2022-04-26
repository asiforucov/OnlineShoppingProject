using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.ViewModels.ProductBFOS;
using Core.Entities;

namespace Business.Interfaces
{
    public interface IOrderService
    {
        Task<List<Order>> GetAllAsync();
        Task<Order> Get(int id);
        Task Create(OrderVM orderVM);
        Task Remove(int id);
    }
}
