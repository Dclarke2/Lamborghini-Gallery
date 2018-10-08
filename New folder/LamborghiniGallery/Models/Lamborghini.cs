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

        public string DisplayText
        {
            get
            {
                return CarModel + " (" + YearModel + ")";
            }
        }

        public string CoverImageFileName
        {
            get
            {
                return CarModel.Replace(" ", "-").ToLower() + "-" + YearModel + ".jpg";
            }
        }
    }
}