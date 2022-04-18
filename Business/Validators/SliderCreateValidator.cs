using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.Slider;
using Core.Entities;
using FluentValidation;

namespace Business.Validators
{
    public class SliderCreateValidator:AbstractValidator<SliderCreateViewModel>
    {
        public SliderCreateValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("Mətn başlığı boş qala bilməz").NotEmpty().MaximumLength(200);
            RuleFor(p => p.Title).NotNull().WithMessage("Mətn boş qala bilməz").NotEmpty().MaximumLength(200);
            RuleFor(p => p.Photo).NotNull().WithMessage("Şəkil seçilməlidir").NotEmpty();
        }
    }
}
