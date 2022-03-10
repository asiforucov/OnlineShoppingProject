using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ProductBrand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
