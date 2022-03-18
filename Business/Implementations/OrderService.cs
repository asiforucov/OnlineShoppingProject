using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.ProductBFOS;
using Core;
using Core.Entities;

namespace Business.Implementations
{
    public class OrderService : IOrderService
    {
        private readonly IUnitOfWork _unitOfWork;
        public OrderService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public Task Create(OrderVM orderVM)
        {
            throw new NotImplementedException();
        }

        public Task<Order> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Order>> GetAllAsync()
        {
            return await _unitOfWork.orderRepository.GetAllAsync();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
