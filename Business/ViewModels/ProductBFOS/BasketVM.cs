using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Business.ViewModels.ProductBFOS
{
    public class BasketVM
    {
        public List<Core.Entities.Product> Products { get; set; }
        public List<ProductOperation> ProductOperations { get; set; }
        public List<Core.Entities.ProductImage> ProductImages { get; set; }
    }
}
