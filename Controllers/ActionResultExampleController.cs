using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;
namespace MVCExample.Controllers
{
    public class ActionResultExampleController : Controller
    {
        // GET: ActionResultExample
        public PartialViewResult Index()
        {
            return PartialView();
        }
        public ContentResult About()
        {
            return Content("<h1>Welcome in About us Page</h1>");
        }
        public ViewResult Services()

        {
            return View();
        }
        public RedirectResult Contact()
        {
            // return Redirect("../Welcome/Index");
            return Redirect("http://shivaconceptsolution.com");
        }
        public ActionResult Gallery()
        {
            return RedirectToAction("Index", "Welcome");
        }
       // public JsonResult SHOWData()
       // {
       //     var stus = new List<Student>
       //{
       //       new Student{rno=1001, sname="XYZ"},
       //       new Student{rno=1002, sname="ABC"}
       //};
       //     return Json(stus, JsonRequestBehavior.AllowGet);
       // }
        public FileResult ShowPageData()
        {
            return File("/Web.config", "text");

        }

    }
}