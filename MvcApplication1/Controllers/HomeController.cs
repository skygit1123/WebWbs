using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = string.Empty;

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Services()
        {
            ViewBag.Message = "Your services page.";

            return View();
        }


        public ActionResult Events()
        {
            ViewBag.Message = "Your events page.";

            return View();
        }

        public ActionResult Accounting()
        {
            ViewBag.Message = "Your accounting and bookkeeping";

            return View();
        }

        public ActionResult Management()
        {
            ViewBag.Message = "Your management";

            return View();
        }

        public ActionResult Tax()
        {
            ViewBag.Message = "Your tax";

            return View();
        }

        public ActionResult Value()
        {
            ViewBag.Message = "Your value";

            return View();
        }
    }
}
