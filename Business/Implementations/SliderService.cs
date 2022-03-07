using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Business.Interfaces;
using Business.Tools;
using Business.ViewModels.Slider;
using Core;
using Core.Entities;
using Microsoft.AspNetCore.Hosting;

namespace Business.Implementations
{
    public class SliderService : ISliderService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _env;

        public SliderService(IUnitOfWork unitOfWork, IWebHostEnvironment env)
        {
            _unitOfWork = unitOfWork;
            _env = env;
        }


        public async Task Create(SliderCreateViewModel sliderViewModel)
        {
            string photoFileName = await sliderViewModel.Photo.SaveFileAsync(_env.WebRootPath, "Assets", "image", "slider");
            var newSlider = new Slider()
            {
                Name = sliderViewModel.Name,
                Title = sliderViewModel.Title,
                Image = photoFileName
            };
            await _unitOfWork.sliderRepository.CreateAsync(newSlider);
            await _unitOfWork.SaveAsync();
        }

        public async Task<List<Slider>> GetAllAsync()
        {
            return await _unitOfWork.sliderRepository.GetAllAsync();
        }

        public async Task Remove(int id)
        {
            Slider slider = await _unitOfWork.sliderRepository.Get(s => s.Id == id);
            _unitOfWork.sliderRepository.Remove(slider);
            await _unitOfWork.SaveAsync();
        }

        public Task Update(int id, SliderUpdateViewModel sliderViewModel)
        {
            throw new NotImplementedException();
        }

      
    }
}
