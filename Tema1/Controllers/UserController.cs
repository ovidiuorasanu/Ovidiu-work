﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tema1.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            var nume1 = "Andrei";
            var nume2 = "Andreea";
            var nume3 = "Alexandru";
            var nume4 = "Alexandra";
            var nume5 = "Mirabelia";
            return View();
        }
        // GET: User
        public ActionResult Details()
        {
            return View();
        } // GET: User
        public ActionResult List()
        {
            return View();
        }
    }
}