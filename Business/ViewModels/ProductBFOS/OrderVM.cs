using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Business.ViewModels.ProductBFOS
{
    public class OrderVM
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }
        public string PostalCode { get; set; }
        public string Adress { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string ApplicationUserId { get; set; }
        public int ProductId { get; set; }

    }
}
