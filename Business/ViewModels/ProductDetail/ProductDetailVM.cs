using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels.ProductDetail
{
    public class ProductDetailVM
    {
        public Core.Entities.Product product { get; set; }
        public List<Core.Entities.Comment> Comments { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public int ProductId { get; set; }
    }
}
