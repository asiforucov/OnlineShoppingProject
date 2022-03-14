using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels.Comment
{
    public class CommentCreateViewModel
    {
        public string Content { get; set; }
        public int ProductId { get; set; }
        public string UserId { get; set; }
    }
}
