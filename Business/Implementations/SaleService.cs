using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.Home;
using Core;
using Core.Entities;
using Microsoft.AspNetCore.Hosting;

namespace Business.Implementations
{
    public class SaleService : ISaleService
    {
        private readonly IUnitOfWork _unitOfWork;

        public SaleService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<Sale> Get()
        {
            var sale = await _unitOfWork.saleRepository.GetAllAsync();
            return sale.FirstOrDefault();
        }

        public async Task Update(SaleVM saleVm)
        {
            var sale = await _unitOfWork.saleRepository.GetAllAsync();
            var saleTimer = sale.FirstOrDefault();
            saleTimer.Title = saleVm.Title;
            saleTimer.Description = saleVm.Description;
            saleTimer.Time = saleVm.Time;
            _unitOfWork.saleRepository.Update(saleTimer);
            await _unitOfWork.SaveAsync();
        }
    }
}
