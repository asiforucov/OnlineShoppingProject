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
            RuleFor(p => p.Name).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(p => p.Surname).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(p => p.PhoneNumber).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(p => p.City).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(p => p.Color).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(p => p.Size).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(p => p.Adress).NotNull().NotEmpty().MaximumLength(200);
            RuleFor(p => p.PostalCode).NotNull().NotEmpty().MaximumLength(200);
        }
    }
}
