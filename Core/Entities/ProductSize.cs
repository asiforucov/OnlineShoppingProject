using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ProductSize
    {
        public int Id { get; set; }
        public string Size { get; set; }
        public bool IsDeleted { get; set; }
    }
}
