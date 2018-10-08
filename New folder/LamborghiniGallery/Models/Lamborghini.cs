using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LamborghiniGallery.Models
{
    public class Lamborghini
    {
        public int Id { get; set; }
        public string CarModel { get; set; }
        public int YearModel { get; set; }
        public string DescriptionHtml { get; set; }
        public Variant[] Variants { get; set; }
        public bool Favorite { get; set; }
    }
}