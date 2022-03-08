using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.Auth;
using FluentValidation;

namespace Business.Validators
{
    public class RegisterValidator:AbstractValidator<RegisterViewModel>
    {
        public RegisterValidator()
        {
                RuleFor(r=>r.FullName).NotNull().NotEmpty().MaximumLength(100);
                RuleFor(r=>r.Username).NotNull().NotEmpty().MaximumLength(50);
                RuleFor(r=>r.Email).NotNull().NotEmpty().MaximumLength(70).EmailAddress();
                RuleFor(r=>r.Password).NotNull().NotEmpty().MaximumLength(64);
                RuleFor(r=>r.ConfirmPassword).NotNull().NotEmpty().MaximumLength(64);
        }
    }
}
