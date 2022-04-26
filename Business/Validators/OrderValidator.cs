using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.ProductBFOS;
using Business.ViewModels.Slider;
using FluentValidation;

namespace Business.Validators
{
    public class OrderValidator : AbstractValidator<OrderVM>
    {
        public OrderValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("Adınızı daxil edin").NotEmpty().MaximumLength(200);
            RuleFor(p => p.Surname).NotNull().WithMessage("Soyadınızı daxil edin").NotEmpty().MaximumLength(200);
            RuleFor(p => p.PhoneNumber).NotNull().WithMessage("Telefon nömrənizi daxil edin").NotEmpty().MaximumLength(200);
            RuleFor(p => p.City).NotNull().WithMessage("Şəhər daxil edin").NotEmpty().MaximumLength(200);
            RuleFor(p => p.Color).NotNull().WithMessage("Məhsulun istədiyiniz rəngini seçin").NotEmpty().MaximumLength(200);
            RuleFor(p => p.Size).NotNull().WithMessage("Məhsulun istədiyiniz ölçüsünü seçin").NotEmpty().MaximumLength(200);
            RuleFor(p => p.Adress).NotNull().WithMessage("Ünvan daxil edin").NotEmpty().MaximumLength(200);
            RuleFor(p => p.PostalCode).NotNull().WithMessage("Poçt nömrəsi daxil edin").NotEmpty().MaximumLength(200);
        }
    }
}
