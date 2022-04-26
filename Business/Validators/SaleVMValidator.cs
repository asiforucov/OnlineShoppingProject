using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.Home;
using FluentValidation;

namespace Business.Validators
{
    public class SaleVMValidator : AbstractValidator<SaleVM>
    {
        public SaleVMValidator()
        {
            RuleFor(p => p.Title).NotNull().NotEmpty().MaximumLength(255).WithMessage("Zəhmət olmasa endirim başlığını daxil edin !");
            RuleFor(p => p.Description).NotNull().NotEmpty().MaximumLength(255).WithMessage("Zəhmət olmasa endirim haqqında məlumat daxil edin !");
            RuleFor(p => p.Time).NotNull().NotEmpty().WithMessage("Zəhmət olmasa endirim tarixi daxil edin !").GreaterThan(DateTime.Now).WithMessage("Keçmiş tarixi daxil edə bilməzsiniz !");
        }
    }
}
