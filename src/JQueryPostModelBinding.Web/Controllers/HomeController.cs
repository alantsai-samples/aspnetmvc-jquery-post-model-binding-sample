﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JQueryPostModelBinding.Web.Models;

namespace JQueryPostModelBinding.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(FormPostModel model)
        {
            return View(model);
        }
    }
}