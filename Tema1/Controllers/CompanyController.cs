﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Tema1.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult Index()
        {

            return View();
        }
        // GET: Company
        public ActionResult Details()
        {
            var nume1 = "Andrei";
            var nume2 = "Andreea";
            var nume3 = "Alexandru";
            var nume4 = "Alexandra";
            var nume5 = "Mirabelia";
            ViewBag.a = nume1;
            ViewBag.b = nume2;
            ViewBag.c = nume3;
            ViewBag.d = nume4;
            ViewBag.e = nume5;
            return View();
        }   // GET: Company
        public ActionResult List()
        {
            var nume1 = "Andrei";
            var nume2 = "Andreea";
            var nume3 = "Alexandru";
            var nume4 = "Alexandra";
            var nume5 = "Mirabelia";
            ViewBag.a = nume1;
            ViewBag.b = nume2;
            ViewBag.c = nume3;
            ViewBag.d = nume4;
            ViewBag.e = nume5;
            return View();
        }
    }
}