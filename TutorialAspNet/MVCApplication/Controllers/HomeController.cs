﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*
controllers that handle incoming requests and user interaction
*/
namespace MVCApplication.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Programs()
        {
            return View();
        }

        public ActionResult Spotlight()
        {
            return View();
        }
    }
}