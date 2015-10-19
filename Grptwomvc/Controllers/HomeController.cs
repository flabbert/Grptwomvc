using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Grptwomvc.Models;

namespace Grptwomvc.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        public ActionResult Index()
        {
            List<Message> mlist = _db.Messages.ToList();
            return View(mlist);
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
        public ActionResult Message_board()
        {
            ViewBag.Message = "Message board";

            return View();
        }
    }
}