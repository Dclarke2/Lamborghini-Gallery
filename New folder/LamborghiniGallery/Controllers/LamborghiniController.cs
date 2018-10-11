using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using LamborghiniGallery.Data;
using LamborghiniGallery.Models;

namespace LamborghiniGallery.Controllers
{
    public class LamborghiniController : Controller
    {
        private LamborghiniRepository _lamborghiniRepository = null;
        public LamborghiniController() //Instantiating our repository within in. 
        {
            _lamborghiniRepository = new LamborghiniRepository();  //Instantiating the _lamborghinirepository   
        }
        public ActionResult Index()
        {

            var lamborghini = _lamborghiniRepository.GetLamborghinis();
            return View(lamborghini);

        }
        public ActionResult Detail(int? id) //<-- '?' id only accepts an integer atm which isn't 'nullable'. the '?' allows us to pass a nullable type if an int isn't provided. 
        {                               //id passed into browser 
            if (id == null)
            {
                return HttpNotFound();
            }
            var lamborghini = _lamborghiniRepository.GetLamborghini((int)id);//cast (int) allows passage of underlying value from nullable type. So what is should actually be such as int type.  
            return View(lamborghini);
            
            
        }


    }
}