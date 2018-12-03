using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tema1.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            var nume1 = "Andrei";
            var nume2 = "Andreea";
            var nume3 = "Alexandru";
            var nume4 = "Alexandra";
            var nume5 = "Mirabelia";

            



            return View();
        }
        // GET: Admin
        public ActionResult Details()
        {
            return View();
        }        // GET: Admin
        public ActionResult List()
        {
            return View();
        }
    }


}