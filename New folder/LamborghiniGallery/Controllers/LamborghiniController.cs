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
            if (DateTime.Today.DayOfWeek == DayOfWeek.Monday)
            {
                return new RedirectResult("/");



            }
            return Content("Helo from the controller");


            

            
        }


    }
}