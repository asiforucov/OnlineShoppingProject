using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities
{
    public class Comment
    {
        public int Id { get; set; }
        public DateTime CreateDT { get; set; }
        public string UserName { get; set; }
        public string Content { get; set; }
        public bool IsDelete { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
