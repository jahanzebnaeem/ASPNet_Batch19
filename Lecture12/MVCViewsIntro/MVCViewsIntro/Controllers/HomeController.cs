using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCViewsIntro.Models;

namespace MVCViewsIntro.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //return Json(new Country { ID = 1, Name = "Pakistan" });
            //return View("Default");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}