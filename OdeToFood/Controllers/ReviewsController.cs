//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using OdeToFood.Models;

//namespace OdeToFood.Controllers
//{
//    public class ReviewsController : Controller
//    {
//        // GET: Reviews
//        public ActionResult Index()
//        {
//            var model = from r in _myRestaurantReviews
//                orderby r.Country
//                select r;

//            return View(model);
//        }

//        // GET: Reviews/Details/5
//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        // GET: Reviews/Create
//        public ActionResult Create()
//        {
//            return View();
//        }

//        // POST: Reviews/Create
//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Reviews/Edit/5
//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        // POST: Reviews/Edit/5
//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        // GET: Reviews/Delete/5
//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        // POST: Reviews/Delete/5
//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        private List<RestaurantReview> _myRestaurantReviews = new List<RestaurantReview>
//        {
//            new RestaurantReview(){ City = "Barcelona", Id = 1, Country = "Spain", Name = "Ca la Marieta", Rating = "7"},
//            new RestaurantReview(){ City = "Pamplona", Id = 2,Country = "Spain", Name="Lagunak", Rating= "6"},
//            new RestaurantReview(){ City = "Lleida", Id = 3,Country = "Spain", Name="La Huerta", Rating= "8"},
//            new RestaurantReview(){ City = "New York", Id = 4,Country = "USA", Name="Sorpaso", Rating= "8"},
//             new RestaurantReview(){City = "Buenos Aires", Id = 5, Country = "Argentina", Name = "Zepellon Jr.", Rating = "3"}
//        };

//    }
//}
