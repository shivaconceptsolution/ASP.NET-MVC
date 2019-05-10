using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;
namespace MVCExample.Controllers
{
    public class CalculateSIController : Controller
    {
        // GET: CalculateSI
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(SI s)
        {
           
            ViewBag.Result = (s.P * s.R * s.T) / 100;
            return View();
        }
    }
}