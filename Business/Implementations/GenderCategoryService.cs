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
        

        public async Task<GenderCategory> Get(int id)
        {
            return await _unitOfWork.genderCategoryRepository.Get(gc => gc.Id == id);
        }

        public async Task<List<GenderCategory>> GetAllAsync()
        {
            return await _unitOfWork.genderCategoryRepository.GetAllAsync();
        }

        public async Task Create(GenderCategoryCreateViewModel model)
        {
            var newGender = new GenderCategory()
            {
                Name = model.Name
            };
            await _unitOfWork.genderCategoryRepository.CreateAsync(newGender);
            await _unitOfWork.SaveAsync();
        }

        public async Task Update(int id, GenderCategoryUpdateViewModel model)
        {
            GenderCategory dbGender = await _unitOfWork.genderCategoryRepository.Get(b => b.Id == id);
            dbGender.Name = model.Name;
            await _unitOfWork.SaveAsync();
        }

        public async Task Remove(int id)
        {
            GenderCategory dbGender = await _unitOfWork.genderCategoryRepository.Get(b => b.Id == id);
            dbGender.IsDeleted = true;
            await _unitOfWork.SaveAsync();

        }
    }
}
