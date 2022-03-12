using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.Product;
using FluentValidation;

namespace Business.Validators
{
    public class ProductCreateVMValidator:AbstractValidator<ProductCreateViewModel>
    {
        public ProductCreateVMValidator()
        {
            RuleFor(p => p.Name).NotNull().NotEmpty().MaximumLength(255);
            RuleFor(p => p.Information).NotNull().NotEmpty().MaximumLength(1000);
            RuleFor(p => p.Price).NotNull().NotEmpty();
            RuleFor(p => p.Count).NotNull().NotEmpty();
            RuleFor(p => p.Photo).NotNull().NotEmpty();
        }
    }
}
