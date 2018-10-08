using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LamborghiniGallery.Controllers
{
    public class LamborghiniController : Controller
    {
        public ActionResult Detail()
        {
            ViewBag.CarModel = "Lamborghini Huracan";
            ViewBag.YearModel = 2018;
            ViewBag.Description = "<p>The Lamborghini Huracán (Spanish for \"hurricane\"; [uɾaˈkan]) is a sports car manufactured by Italian automotive manufacturer Lamborghini replacing the previous V10 flagship, the Gallardo. The Huracán made its worldwide debut at the 2014 Geneva Auto Show, and was released in the market the second quarter of 2014. The LP 610-4 designation comes from the fact that this car has 610 metric horsepower and 4 wheel drive, while LP stands for \"Longitudinale Posteriore\", which refers to the longitudinal mid-rear engine position. The Huracán was named \"The Supercar of the Year 2014\" by automotive magazine <strong>Top Gear</strong>.</p>";
            ViewBag.Variants = new string[]
            {
                "2.1 huracán lp 610-4 coupe (2014–present)",
                "2.2 huracán lp 610-4 polizia",
                "2.3 huracán lp 610-4 avio",
                "2.4 huracán lp 610-4 spyder (2016–present)",
                "2.5 huracán lp 580-2 (2016-present)",
                "2.6 huracán lp 580-2 pope francis",
                "2.7 huracán lp 580-2 spyder (2016-present)",
                "2.8 huracán lp 640-4 performante (2017-present)",
                "2.9 huracán lp 640-4 performante spyder (2018–present)"


            };




            return View();
        }


    }
}