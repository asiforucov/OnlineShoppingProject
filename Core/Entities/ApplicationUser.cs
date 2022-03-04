using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ApplicationUser:IdentityUser
    {
        public string Name { get; set; }
        public string City { get; set; }
        public string Adress { get; set; }
        public string PostCode { get; set; }
        public string FullName { get; set; }
        public string Surname { get; set; }
        public bool IsActivated { get; set; }

    }
}
