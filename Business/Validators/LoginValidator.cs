using System;
using System.Collections.Generic;
using System.Text;
using FluentValidation;

namespace Business.Validators
{
    public class LoginValidator : AbstractValidator<LoginValidator>
    {
        public LoginValidator()
        {
        //RuleFor(l => l.Fu).NotNull().NotEmpty().MaximumLength(200);

        }
    }
}
