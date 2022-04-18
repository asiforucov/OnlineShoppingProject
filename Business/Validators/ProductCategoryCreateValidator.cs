using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.ProductCategory;
using FluentValidation;

namespace Business.Validators
{
    public class ProductCategoryCreateValidator :AbstractValidator<ProductCategoryCreateViewModel>
    {
        public ProductCategoryCreateValidator()
        {
            RuleFor(r => r.Name).NotNull().WithMessage("Kateqoriya adı boş qala bilməz").NotEmpty();
        }
    }
}
