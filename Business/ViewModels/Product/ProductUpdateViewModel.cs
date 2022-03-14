using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels.Product
{
    public class ProductUpdateViewModel
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public int Count { get; set; }
        public string Information { get; set; }
        public int ProductCategoryId { get; set; }
        public int ProductBrandId { get; set; }
        public int GenderCategoryId { get; set; }
        public List<IFormFile> Photo { get; set; }
    }
}
