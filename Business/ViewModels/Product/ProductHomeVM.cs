using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels.Product
{
    public class ProductHomeVM
    {
        public List<Core.Entities.Product> Products { get; set; }
        public List<Core.Entities.ProductImage> ProductImages { get; set; }
        public List<Core.Entities.ProductCategory> ProductCategories { get; set; }
    }
}
