﻿using Microsoft.AspNetCore.Mvc;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View(new string[] { "Apple", "Orange", "Pear" });
        }

        public ViewResult List()
        {
            return View();
        }
    }
}