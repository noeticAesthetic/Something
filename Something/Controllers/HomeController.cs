using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Something.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Home Page";
            return View();
        }

        public ActionResult Credits()
        {
            ViewBag.Message = "Site made possible by:";
            return View();
        }

        public ActionResult ContactForm()
        {
            ViewBag.Message = "Contact us.";
            return View();
        }

        public ActionResult Recommended()
        {
            ViewBag.Message = "Recommened.";
            return View();
        }

        public ActionResult TODO()
        {
            ViewBag.Message = "TODO List.";
            return View();
        }
    }
}
