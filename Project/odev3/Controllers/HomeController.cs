using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev3.Models;
using System.Data.Entity;

namespace odev3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            var movies = db.Movies_tbl.ToList();
            return View(movies);
        }
        public ActionResult Search(string name)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            var movies = db.Movies_tbl.Select(x=>x.MovieName).ToList();
            var movie = movies.Contains(name);
            return View(movie);
        }
        [ChildActionOnly]
        public ActionResult _News()
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            var movies = db.News_tbl.ToList();
            return View(movies);
        }
        [ChildActionOnly]
        public ActionResult _Rating(int? id)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            Movies_tbl movie = db.Movies_tbl.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [ChildActionOnly]
        public ActionResult _AddRating(int id)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            List<Rating_tbl> ratings = db.Rating_tbl.Where(x => x.MovieID == id).ToList() ;
            var rating = new Rating_tbl();
            if (ratings.Count != 0)
            {
                rating = ratings.Where(x => x.UserName == User.Identity.Name).FirstOrDefault();
            }
            if (rating == null || ratings.Count==0){
                rating = new Rating_tbl();
                rating.MovieID = id;
                rating.Rating = -1;
                    };
            return View(rating);
        }

        // GET: Movie_tbl/Edit/5
        public ActionResult Info(int? id)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            Movies_tbl movie = db.Movies_tbl.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }
        [HttpPost]
        public ActionResult Info(Rating_tbl rating_tbl)
        {
            if (ModelState.IsValid)
            {
                Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
                db.Rating_tbl.Add(rating_tbl);
                db.SaveChanges();
                return RedirectToAction("Info","Home",new {id = rating_tbl.MovieID});
            }
            return View(rating_tbl);
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [ChildActionOnly]
        public ActionResult Add_Review(int id)
        {
            ViewBag.Message = "Add Review";
            Reviews_tbl review = new Reviews_tbl();
            review.MovieId = id;
            return View(review);
        }
        [HttpPost]
        public ActionResult Add_Review(Reviews_tbl review)
        {
            ViewBag.Message = "Add Review";

            if (ModelState.IsValid)
            {
                Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
                db.Reviews_tbl.Add(review);
                db.SaveChanges();
                return RedirectToAction("Info", "Home", new { id = review.MovieId });
            }
            return View(review);
        }

    }
}