using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.Auth;
using FluentValidation;
using Microsoft.AspNetCore.Diagnostics;

namespace Business.Validators
{
    public class RegisterValidator:AbstractValidator<RegisterViewModel>
    {
        public RegisterValidator()
        {
                RuleFor(r=>r.FullName).NotNull().WithMessage("Ad və Soyad boş qala bilməz").NotEmpty().MaximumLength(100);
                RuleFor(r=>r.PhoneNumber).NotNull().WithMessage("Telefon nömrəsi boş qala bilməz").NotEmpty().MaximumLength(20);
                RuleFor(r=>r.Username).NotNull().WithMessage("İstifadəçi adı boş qala bilməz").NotEmpty().MaximumLength(50);
                RuleFor(r=>r.Email).NotNull().WithMessage("Email adresi boş qala bilməz").NotEmpty().MaximumLength(70).EmailAddress();
                RuleFor(r=>r.Password).NotNull().WithMessage("Şifrə boş qala bilməz").NotEmpty().MaximumLength(64);
                RuleFor(r=>r.ConfirmPassword).NotNull().WithMessage("Şifrə boş qala bilməz").NotEmpty().MaximumLength(64);
        }
    }
}
