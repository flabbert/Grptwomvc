using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grptwomvc.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Description of Group two";

            return View();
        }

        public ActionResult Images()
        {
            ViewBag.Message = "Images from Nasa";

            return View();
        }
        public ActionResult Lorem_Ipsum()
        {
            ViewBag.Message = "Lorem Ipsum";

            return View();
        }
    }
}