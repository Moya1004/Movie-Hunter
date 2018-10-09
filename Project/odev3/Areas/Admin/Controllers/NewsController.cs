using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev3.Models;
using System.Data.Entity;

namespace odev3.Areas.Admin.Controllers
{
    public class NewsController : AdminController
    {
        //Index
        public ActionResult Index()
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            var news = db.News_tbl.ToList();
            return View(news);
        }
        //Add Get Method
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost] // Add Post Method
        public ActionResult Add(News_tbl movie)
        {
            if (ModelState.IsValid)
            {
                Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
                db.News_tbl.Add(movie);
                db.SaveChanges();
                return RedirectToAction("Index", "News");
            }
            return View(movie);
        }


        //Edit Get Method
        public ActionResult Edit(int id)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            var news = db.News_tbl.Find(id);
            return View(news);
        }
        [HttpPost] // Edit Post Method
        public ActionResult Edit(News_tbl news)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            if (ModelState.IsValid)
            {
                db.Entry(news).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", "News");
            }
            return View(news);
        }


        // Delete
        public ActionResult Delete(int id)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            var news = db.News_tbl.Find(id);
            return View(news);
        }
        // Delete Confirmation
        public ActionResult DeleteConfirmation(int id)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            var news = db.News_tbl.Find(id);
            return View(news);
        }

        // Delete Confirmed
        public ActionResult DeleteConfirmed(int id)
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            News_tbl news = db.News_tbl.Find(id);
            db.News_tbl.Remove(news);
            db.SaveChanges();
            return RedirectToAction("Index", "News");
        }
    }
}