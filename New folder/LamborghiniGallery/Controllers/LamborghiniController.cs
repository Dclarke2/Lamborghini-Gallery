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
            

            
            return View(lamborghini);
        }


    }
}