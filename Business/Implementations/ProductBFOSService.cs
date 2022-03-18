using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Core;
using Core.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Business.Implementations
{
    public class ProductBFOSService : IProductBFOSService
    {
        private readonly IUnitOfWork _unitOfWork;
        public ProductBFOSService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task DeleteBasket(int id, string userid)
        {
            var bfos = await _unitOfWork.productBFOSRepository.Get(p =>
                p.ProductId == id && p.ApplicationUserId == userid && p.IsBasket == true);
            bfos.IsBasket = false;
            _unitOfWork.productBFOSRepository.Update(bfos);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteFavorite(int id, string userid)
        {
            var bfos = await _unitOfWork.productBFOSRepository.Get(p =>
                p.ProductId == id && p.ApplicationUserId == userid && p.IsFavorite == true);
            bfos.IsFavorite = false;
            _unitOfWork.productBFOSRepository.Update(bfos);
            await _unitOfWork.SaveAsync();
        }

        public async Task DeleteOrdered(int id, string userid)
        {
            var bfos = await _unitOfWork.productBFOSRepository.Get(p =>
                p.ProductId == id && p.ApplicationUserId == userid && p.Ordered == true);
            bfos.Ordered = false;
            _unitOfWork.productBFOSRepository.Update(bfos);
            await _unitOfWork.SaveAsync();
        }

        public Task<ProductOperation> Get(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ProductOperation>> GetAllAsync(string userId)
        {
            return await _unitOfWork.productBFOSRepository.GetAllAsync(po => po.IsDeleted == false && po.ApplicationUserId == userId,"Product");
        }

        public async Task<List<ProductOperation>> GetAllBasketAsync(string userId)
        {
            return await _unitOfWork.productBFOSRepository.GetAllAsync(po => po.IsDeleted == false && po.ApplicationUserId == userId && po.IsBasket == true, "Product");
        }

        public async Task<List<ProductOperation>> GetAllFavouriteAsync(string userId)
        {
            return await _unitOfWork.productBFOSRepository.GetAllAsync(po => po.IsDeleted == false && po.ApplicationUserId == userId && po.IsFavorite == true, "Product");
        }

        public async Task<List<ProductOperation>> GetAllOrderedAsync(string userId)
        {
            return await _unitOfWork.productBFOSRepository.GetAllAsync(po => po.IsDeleted == false && po.ApplicationUserId == userId && po.Ordered == true, "Product");
        }

        public Task<List<ProductOperation>> GetAllSendAsync(string userId)
        {
            throw new NotImplementedException();
        }

        public async Task SetBasket(int id, string userid)
        {
            var productOperation = new ProductOperation()
            {
                ProductId = id,
                ApplicationUserId = userid,
                IsBasket = true
            };

            await _unitOfWork.productBFOSRepository.CreateAsync(productOperation);
            await _unitOfWork.SaveAsync();
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

        public async Task SetOrdered( string userid)
        {
            var dbBFOS = await _unitOfWork.productBFOSRepository.Get(so=>so.IsBasket==true&& so.ApplicationUserId == userid && so.IsBasket == true);
            dbBFOS.IsBasket = false;
            dbBFOS.Ordered = true;
            _unitOfWork.productBFOSRepository.Update(dbBFOS);
            await _unitOfWork.SaveAsync();
        }
        [HttpPost]
        public async Task SetOrdered(int id, string userid)
        {
            var dbBFOS = await _unitOfWork.productBFOSRepository.Get(so => so.ProductId==id && so.ApplicationUserId == userid && so.IsBasket == true);
            dbBFOS.IsBasket = false;
            dbBFOS.Ordered = true;
            _unitOfWork.productBFOSRepository.Update(dbBFOS);
            await _unitOfWork.SaveAsync();
        }

        public Task SetSend(int id, string userid)
        {
            throw new NotImplementedException();
        }

       
    }
}
