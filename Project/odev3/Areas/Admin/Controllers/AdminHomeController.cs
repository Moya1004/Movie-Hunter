using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using odev3.Areas.Admin.Models;
using System.Data.Entity;

namespace odev3.Areas.Admin.Controllers
{
    public class AdminHomeController : AdminController
    {
        // GET: Admin/Home
        public ActionResult Index()
        {
            Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
            List<Tasks_tbl> tasks = db.Tasks_tbl.ToList();
            return View(tasks);
        }
        public ActionResult AddNewTask()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult AddNewTask(TaskModel model)
        {
            if (ModelState.IsValid)
            {
                Tasks_tbl task = new Tasks_tbl();
                var path = Server.MapPath("/Content/images/");
                var filename = model.Task_Avatar.FileName;
                var fullpath = path + filename;
                if (model.Task_Avatar != null && model.Task_Avatar.ContentLength > 0)
                {
                    model.Task_Avatar.SaveAs(path + filename);
                }
                task.Full_Task = model.Full_Task;
                task.Task_Avatar = "/Content/images/" + filename; ;
                task.Task_Date_Day = model.Task_Date_Day;
                task.Task_Date_Month = model.Task_Date_Month;
                task.Task_Header = model.Task_Header;
                Movie_ReviewDBEntities db = new Movie_ReviewDBEntities();
                db.Tasks_tbl.Add(task);
                db.SaveChanges();
                return RedirectToAction("Index", "AdminHome");
            }
            return View(model);
        }
    }
}
