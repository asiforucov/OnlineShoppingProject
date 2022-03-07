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
            RuleFor(p => p.Name).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(p => p.Title).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(p => p.Photo).NotNull().NotEmpty();
        }
    }
}
