using System;
using System.Collections.Generic;
using System.Text;
using Business.ViewModels.Paginate;

namespace Business.ViewModels.Home
{
    public class HomePaginatedVM
    {
        public List<Core.Entities.Slider> Sliders { get; set; }
        public List<Core.Entities.GenderCategory> GenderCategory { get; set; }
        public List<Core.Entities.ProductCategory> ProductCategories { get; set; }
        public List<Core.Entities.ProductBrand> ProductBrands { get; set; }
        public Paginate<Core.Entities.Product> Product { get; set; }
        public List<Core.Entities.Product> Products { get; set; }

        public List<Core.Entities.ProductImage> ProductImages { get; set; }
    }
}
