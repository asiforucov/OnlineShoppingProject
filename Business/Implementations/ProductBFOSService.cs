using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Core;
using Core.Entities;

namespace Business.Implementations
{
    public class ProductBFOSService : IProductBFOSService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductBFOSService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task<ProductOperation> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductOperation>> GetAllAsync(string userId)
        {
            return await _unitOfWork.productBFOSRepository.GetAllAsync(po => po.IsDeleted == false && po.ApplicationUserId == userId);
        }

        public Task<List<ProductOperation>> GetAllBasketAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductOperation>> GetAllFavouriteAsync(string userId)
        {
            return await _unitOfWork.productBFOSRepository.GetAllAsync(po => po.IsDeleted == false && po.ApplicationUserId == userId && po.IsFavorite == true);
        }

        public Task<List<ProductOperation>> GetAllOrderedAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductOperation>> GetAllSendAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public Task SetBasket(int id, string userid)
        {
            throw new NotImplementedException();
        }

        public async Task SetFavourite(int id, string userid)
        {
            var productOperation = new ProductOperation()
            {
                ProductId = id,
                ApplicationUserId = userid,
                IsFavorite = true
            };

            await _unitOfWork.productBFOSRepository.CreateAsync(productOperation);
            await _unitOfWork.SaveAsync();
        }

        public Task SetOrdered(int id, string userid)
        {
            throw new NotImplementedException();
        }

        public Task SetSend(int id, string userid)
        {
            throw new NotImplementedException();
        }
    }
}
