using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CircuitsDashboard.Controllers
{
    public class QuotesController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Requested()
        {
            return View();
        }

        public ActionResult Received()
        {
            return View();
        }
    }
}