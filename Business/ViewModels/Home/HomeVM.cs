using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Business.ViewModels.Home
{
    public class HomeVM
    {
        public List<Core.Entities.Slider> Sliders { get; set; }
        public List<Core.Entities.GenderCategory> GenderCategory { get; set; }
        public List<Core.Entities.ProductCategory> ProductCategories { get; set; }
        public List<Core.Entities.ProductBrand> ProductBrands { get; set; }
        public List<Core.Entities.Product> Product { get; set; }
        public List<Core.Entities.ProductImage> ProductImages { get; set; }
        public Sale Sale { get; set; }
    }
}
