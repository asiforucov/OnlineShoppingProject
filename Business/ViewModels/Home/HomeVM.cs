using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ViewModels.Home
{
    public class HomeVM
    {
        public List<Core.Entities.Slider> Sliders { get; set; }
        public List<Core.Entities.GenderCategory> GenderCategory { get; set; }
    }
}
