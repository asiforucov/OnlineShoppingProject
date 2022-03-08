using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ProductColor
    {
        public int Id { get; set; }
        public string Color { get; set; }
        public bool IsDeleted { get; set; }
    }
}
