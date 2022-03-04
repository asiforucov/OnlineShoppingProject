using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class GenderCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Product> Product { get; set; }

    }
}
