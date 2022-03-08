using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Http;

namespace Business.ViewModels.Slider
{
    public class SliderUpdateViewModel
    {
        public string Name { get; set; }
        public string Title { get; set; }
        public IFormFile Photo { get; set; }
    }
}
