using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Business.ViewModels.My_User
{
    public class My_UserVM
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<Core.Entities.Product> Products { get; set; }
        public List<Core.Entities.ProductOperation> ProductOperations { get; set; }
    }
}
