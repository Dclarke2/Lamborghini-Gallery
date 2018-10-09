using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LamborghiniGallery.Models;

namespace LamborghiniGallery.Controllers
{
    public class LamborghiniController : Controller
    {
        public ActionResult Detail()
        {
            var lamborghini = new Lamborghini()
            {
                CarModel = "Lamborghini Huracan",
                YearModel = 2018,
                DescriptionHtml = "<p>The Lamborghini Huracán (Spanish for \"hurricane\"; [uɾaˈkan]) is a sports car manufactured by Italian automotive manufacturer Lamborghini replacing the previous V10 flagship, the Gallardo. The Huracán made its worldwide debut at the 2014 Geneva Auto Show, and was released in the market the second quarter of 2014. The LP 610-4 designation comes from the fact that this car has 610 metric horsepower and 4 wheel drive, while LP stands for \"Longitudinale Posteriore\", which refers to the longitudinal mid-rear engine position. The Huracán was named \"The Supercar of the Year 2014\" by automotive magazine <strong>Top Gear</strong>.</p>",
                Variants = new Variant[]
                {
                    new Variant(){ModelName = "2.1 huracán lp 610-4 coupe", ModelYearRelease = "(2014–present)"},
                    new Variant(){ModelName = "2.2 huracán lp 610-4 polizia", ModelYearRelease = "(2015-present)"},
                    new Variant(){ModelName = "2.3 huracán lp 610-4 avio", ModelYearRelease = "(2015-present)"},
                    new Variant(){ModelName = "2.4 huracán lp 610-4 spyder ", ModelYearRelease = "(2016–present)"},
                    new Variant(){ModelName = "2.5 huracán lp 580-2", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.6 huracán lp 580-2 pope francis", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.7 huracán lp 580-2 spyder", ModelYearRelease = "(2016-present)"},
                    new Variant(){ModelName = "2.8 huracán lp 640-4 performante", ModelYearRelease = " (2017-present)"},
                    new Variant(){ModelName = "2.9 huracán lp 640-4 performante spyder", ModelYearRelease = "(2018–present)"},
               

                }

            };

            
            return View(lamborghini);
        }


    }
}