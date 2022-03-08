using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class ProductOperation
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public string ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsFavorite { get; set; }
        public bool IsBasket { get; set; }
        public bool Ordered { get; set; }
        public bool Send { get; set; }
       
    }
}
