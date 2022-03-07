using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.ViewModels.GenderCategory;
using Core;
using Core.Entities;

namespace Business.Implementations
{
    public class GenderCategoryService : IGenderCategoryService
    {
        private readonly IUnitOfWork _unitOfWork;
        public GenderCategoryService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public Task Create(GenderCategoryCreateViewModel genderCategorytViewModel)
        {
            throw new NotImplementedException();
        }

        public async Task<List<GenderCategory>> GetAllAsync()
        {
            return await _unitOfWork.genderCategoryRepository.GetAllAsync();
        }

        public Task Remove(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, GenderCategoryUpdateViewModel genderCategoryViewModel)
        {
            throw new NotImplementedException();
        }
    }
}
