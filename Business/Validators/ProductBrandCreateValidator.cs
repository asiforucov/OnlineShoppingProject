using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.ProductSize;
using FluentValidation;

namespace Business.Validators
{
    public class ProductBrandCreateValidator:AbstractValidator<ProductBrandCreateViewModel>
    {
        public ProductBrandCreateValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("Model adı boş qala bilməz").NotEmpty();
        }
    }
}
