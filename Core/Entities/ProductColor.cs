using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ProductColor
    {
        public int Id { get; set; }
        public string ColorName { get; set; }
        public bool IsDeleted { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
