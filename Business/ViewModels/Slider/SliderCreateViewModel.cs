using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels.Slider
{
    public class SliderCreateViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public IFormFile Photo { get; set; }
    }
}
