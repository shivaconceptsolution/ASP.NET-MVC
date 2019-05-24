using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;
namespace MVCExample.Controllers
{
    public class AjaxController : Controller
    {
        Database1Entities db = new Database1Entities();
        // GET: Ajax
        public ActionResult Index()
        {
            ViewBag.StuData = new SelectList(db.Students, "Rno", "Sname");
            return View();
        }
        public ActionResult searchdemo(int id)
        {
            // var s = from c in db.Students where c.Sname.StartsWith(id) select c;
            var s = from c in db.Students where c.Rno == id select c;
            return View(s.ToList());
        }
    }
}