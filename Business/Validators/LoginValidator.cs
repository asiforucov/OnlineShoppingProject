using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.Auth;
using FluentValidation;

namespace Business.Validators
{
    public class LoginValidator : AbstractValidator<LoginViewModel>
    {
        public LoginValidator()
        {
            RuleFor(r => r.Email).NotNull().WithMessage("Email adresi boş qala bilməz").NotEmpty().MaximumLength(70).EmailAddress();
            RuleFor(r => r.Password).NotNull().WithMessage("Şifrə boş qala bilməz").NotEmpty().MaximumLength(64);

        }
    }
}
