using Something.Models;
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

        public ActionResult Info()
        {
            ViewBag.Title = "Info";
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

        public ActionResult Recommended(RecommendedModel _recommendedModel)
        {
            if (_recommendedModel.Password == _recommendedModel.Token)
            {
                return View();
            }
            else
            {
                return View("Error");
            }
        }

        public ActionResult TODO()
        {
            ViewBag.Message = "TODO List.";
            return View();
        }
    }
}
