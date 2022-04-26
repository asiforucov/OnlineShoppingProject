using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.Comment;
using FluentValidation;

namespace Business.Validators
{
    public class CommentValidation:AbstractValidator<CommentCreateViewModel>
    {
        public CommentValidation()
        {
            RuleFor(p => p.Content).NotNull().WithMessage("Şərhinizi yazın").NotEmpty();
        }
    }
}
