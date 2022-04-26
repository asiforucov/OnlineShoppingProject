using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.ViewModels.Home;
using Core.Entities;

namespace Business.Interfaces
{
    public interface ISaleService
    {
        Task<Sale> Get();
        Task Update(SaleVM saleVm);
    }
}
