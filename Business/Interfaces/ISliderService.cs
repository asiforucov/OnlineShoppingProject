using Business.ViewModels.Slider;
using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ISliderService
    {
        Task<List<Slider>> GetAllAsync();
        Task Create(SliderCreateViewModel sliderViewModel);
        Task Update(int id, SliderUpdateViewModel sliderViewModel);
        Task Remove(int id);
    }
}
