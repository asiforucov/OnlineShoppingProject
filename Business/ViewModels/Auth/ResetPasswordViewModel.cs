using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Business.ViewModels.Auth
{
    public class ResetPasswordViewModel
    {
        public string Email { get; set; }
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }
        [DataType(DataType.Password),Compare(nameof(NewPassword))]
        public string ConfirmPassword { get; set; }

        public string Token { get; set; }
    }
}
