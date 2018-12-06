using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tema1.Controllers
{
    public class ExtraController : Controller
    {
        // GET: Extra
        public ActionResult Fun()
        {
            return View();
        }

        public ActionResult Test()
        {
            var Greeting = "Welcome to my life!";
            var counter = 103;
            var today = DateTime.Now;
            ViewBag.Gr = Greeting;
            ViewBag.cnter = counter;
            ViewBag.td = today;

            return View();
        }
    }
}