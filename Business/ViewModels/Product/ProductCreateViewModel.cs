using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Business.ViewModels.Product
{
    public class ProductCreateViewModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public string Information { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductColorId { get; set; }
        public int ProductSizeId { get; set; }
        public int GenderCategoryId { get; set; }
        public IFormFile Photo { get; set; }
    }
}
