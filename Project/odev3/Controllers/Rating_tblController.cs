using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using odev3.Models;

namespace odev3.Controllers
{
    public class Rating_tblController : Controller
    {
        private Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();

        // GET: Rating_tbl
        public ActionResult Index()
        {
            return View(db.Rating_tbl.ToList());
        }

        // GET: Rating_tbl/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rating_tbl rating_tbl = db.Rating_tbl.Find(id);
            if (rating_tbl == null)
            {
                return HttpNotFound();
            }
            return View(rating_tbl);
        }

        // GET: Rating_tbl/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Rating_tbl/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RatingID,Rating,MovieID,UserName")] Rating_tbl rating_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Rating_tbl.Add(rating_tbl);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rating_tbl);
        }

        // GET: Rating_tbl/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rating_tbl rating_tbl = db.Rating_tbl.Find(id);
            if (rating_tbl == null)
            {
                return HttpNotFound();
            }
            return View(rating_tbl);
        }

        // POST: Rating_tbl/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RatingID,Rating,MovieID,UserName")] Rating_tbl rating_tbl)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rating_tbl).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rating_tbl);
        }

        // GET: Rating_tbl/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rating_tbl rating_tbl = db.Rating_tbl.Find(id);
            if (rating_tbl == null)
            {
                return HttpNotFound();
            }
            return View(rating_tbl);
        }

        // POST: Rating_tbl/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rating_tbl rating_tbl = db.Rating_tbl.Find(id);
            db.Rating_tbl.Remove(rating_tbl);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
