﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Lab2.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        public IActionResult Details(string item)
        {
            ViewBag.item = "You selected category: "+item;
            return View();
        }
    }
}
