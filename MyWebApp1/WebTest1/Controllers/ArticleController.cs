﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebTest1.Controllers
{
    public class ArticleController : Controller
    {
        // GET: Article
        //public ActionResult Index()
        //{
        //    return View();
        //}
        public string Index()
        {
            return "MVC!!!";
        }
    }
}