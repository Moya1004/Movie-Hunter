using System;
using odev3.Areas.Admin.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev3.Models;
using System.Data.Entity;

namespace odev3.Areas.Admin.Controllers
{
    public class MoviesController : AdminController
    {
        public ActionResult Index()
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            var movies = db.Movies_tbl.ToList();
            return View(movies);
        }
        public ActionResult Edit(int? id)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            var movie = db.Movies_tbl.Find(id);
            return View(movie);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Movies_tbl movie)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            if (ModelState.IsValid)
            {
                db.Entry(movie).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index","Movies");
            }
            return View(movie);
        }
        public ActionResult Delete(int? id)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            var movie = db.Movies_tbl.Find(id);
            return View(movie);
        }
        public ActionResult DeleteConfirmation(int id)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            var movie = db.Movies_tbl.Find(id);
            return View(movie);
        }
        public ActionResult DeleteConfirmed(int id)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            Movies_tbl movies = db.Movies_tbl.Find(id);
            var castsofthismovie = db.Cast_tbl.Where(x => x.Movies == id).ToList();
            var ratingsofthismovie = db.Rating_tbl.Where(x => x.MovieID == id).ToList();
            var reviewsofthismovie = db.Reviews_tbl.Where(x => x.MovieId == id).ToList();
            var newsofthismovie = db.News_tbl.Where(x => x.MovieID == id).ToList();
            db.Rating_tbl.RemoveRange(ratingsofthismovie);
            db.Cast_tbl.RemoveRange(castsofthismovie);
            db.News_tbl.RemoveRange(newsofthismovie);
            db.Reviews_tbl.RemoveRange(reviewsofthismovie);
            db.Movies_tbl.Remove(movies);
            db.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Add(MovieModel model)
        {
            if (ModelState.IsValid)
            {
                Movies_tbl movie = new Movies_tbl();
                var path = Server.MapPath("/Content/images/");
                var filename = model.MoviePoster.FileName;
                var fullpath = path + filename;
                if (model.MoviePoster != null && model.MoviePoster.ContentLength>0)
                {
                    model.MoviePoster.SaveAs(path + filename);
                }
                var x = ViewBag.Date;
                movie.MovieGenre = model.MovieGenre;
                movie.Country = model.Country;
                movie.Director = model.Director;
                movie.Duration = model.Duration;
                movie.MovieName = model.MovieName;
                movie.MoviePoster = "/Content/images/" + filename ;
                movie.Trailer = model.Trailer;
                movie.Writer = model.Writer;
                movie.ReleaseDate = model.ReleaseDate;
                Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
                db.Movies_tbl.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index","Movies");
            }
            return View(model);
        }
    }
}