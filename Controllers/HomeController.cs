using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCExample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            int a = 100;
            int b = 200;
            int c = a - b;
            ViewBag.Result = c;  //viewbag store data and type both
            return View();
        }
       [HttpPost]
        /* public ActionResult Index(int ?id)
         {
             int a = Convert.ToInt32(Request["txtnum1"]);
             ViewBag.Result1 = a * a;
             return View();
         }*/

        public ActionResult Index(string txtnum1)
         {
             int a = Convert.ToInt32(txtnum1);
             ViewBag.Result1 = a * a;
             return View();
         }

    }
}