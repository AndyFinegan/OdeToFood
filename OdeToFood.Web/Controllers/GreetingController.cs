﻿using OdeToFood.Web.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Web.Controllers
{
    public class GreetingController : Controller
    {
        // GET: Greeting
        public ActionResult Index(string name)
        {
            var model = new GreetingsViewModel();
            model.Name = name ?? "no name";
            model.message = ConfigurationManager.AppSettings["message"];
            return View(model);
        }
    }
}