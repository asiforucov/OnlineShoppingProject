using Business.ViewModels.GenderCategory;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IGenderCategoryService
    {
        Task<List<GenderCategory>> GetAllAsync();
        Task<GenderCategory> Get(int id);

        Task Create(GenderCategoryCreateViewModel genderCategorytViewModel);
        Task Update(int id, GenderCategoryUpdateViewModel genderCategoryViewModel);
        Task Remove(int id);
    }
}
