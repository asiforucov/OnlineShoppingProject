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
            RuleFor(p => p.Name).NotNull().WithMessage("Məhsul adı boş qala bilməz").NotEmpty().WithMessage("aa").MaximumLength(255);
            RuleFor(p => p.Information).NotNull().WithMessage("Məhsul haqqında məlumat boş qala bilməz").NotEmpty().MaximumLength(1000);
            RuleFor(p => p.Price).NotNull().WithMessage("Məhsul qiymətsiz ola bilməz").NotEmpty();
            RuleFor(p => p.Color).NotNull().WithMessage("Məhsul üçün ən azı 1 rəng olmalıdır").NotEmpty();
            RuleFor(p => p.Size).NotNull().WithMessage("Məhsul üçün ən azı 1 ölçü olmalıdır").NotEmpty();
            RuleFor(p => p.Count).NotNull().WithMessage("Azı 1 məhsul olmalıdır").NotEmpty();
            RuleFor(p => p.Photo).NotNull().WithMessage("Məhsul üçün azı 1 şəkil olmalıdır").NotEmpty();
        }
    }
}
