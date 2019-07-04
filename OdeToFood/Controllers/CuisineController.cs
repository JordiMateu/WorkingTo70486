using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Filters;

namespace OdeToFood.Controllers
{
    public class CuisineController : Controller
    {
        [Log]
        public ActionResult Search(string name)
        {
            //return Content("HELLO are you looking for " + name + " cuisine");

            throw new Exception("ME CAGON EN TOT");
        }
    }
}