using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.GenderCategory;
using FluentValidation;

namespace Business.Validators
{
    public class GenderCategoryCreateValidation:AbstractValidator<GenderCategoryCreateViewModel>
    {
        public GenderCategoryCreateValidation()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("Boş qala bilməz").NotEmpty();
        }
    }
}
