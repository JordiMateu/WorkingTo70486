using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
    public class HomeController : Controller
    {
		OdeToFoodDb _db = new OdeToFoodDb();

		public ActionResult Index()
		{
			var mode = _db.Restaurants.ToList();

            return View(mode);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            var model = new AboutModel();
            model.Name = "Jordi Mateu";
            model.Location = "Girona. Catalunya";

            return View(model);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

	    protected override void Dispose(bool disposing)
	    {
			if(_db != null)
				_db.Dispose();

		    base.Dispose(disposing);
	    }
    }
}