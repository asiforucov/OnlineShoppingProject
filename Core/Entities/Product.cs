using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public DateTime CreateDT { get; set; }
        public bool IsDeleted { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        //public string Information { get; set; }
        public int ProductCategoryId { get; set; }
        public ProductCategory ProductCategory { get; set; }
        public List<Comment> Comments { get; set; }
         //public int ProductSizeId { get; set; }
        //public ProductSize ProductSize { get; set; }
        //public int ProductColorId { get; set; }
        //public ProductColor ProductColor { get; set; }
        public int GenderCategoryId { get; set; }
        public GenderCategory GenderCategory { get; set; }
        public int ProductBrandId { get; set; }
        public ProductBrand ProductBrand { get; set; }
        public List<ProductImage> ProductImages { get; set; }

    }
}
