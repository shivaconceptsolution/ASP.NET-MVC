using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;
using System.Data.Entity;
namespace MVCExample.Controllers
{
    public class StuController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: Stu
        public ActionResult Index()
        {
            TempData.Keep();

            return View();
        }
        [HttpPost]
        public ActionResult Index(Student s)
        {
            db.Students.Add(s);
            db.SaveChanges();
            ViewBag.data = "Data inserted successfully";
            return View();
        }
        public ActionResult Showdata()
        {
            var s = db.Students.ToList();
            return View(s);
        }
        public ActionResult Edit(int id)
        {
            var s = db.Students.Find(id);
            return View(s);
        }
        [HttpPost]
        public ActionResult Edit(Student s)
        {
            db.Entry(s).State = EntityState.Modified;
            db.SaveChanges();
            ViewBag.data = "Record Updated SuccessFully";
            return View(s);
        }
        public ActionResult Delete(int id)
        {
            var s = db.Students.Find(id);
            db.Students.Remove(s);
            db.SaveChanges();
            return RedirectToAction("Showdata");
        }
    }
}