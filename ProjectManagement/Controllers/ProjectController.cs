﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjectManagement.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult DoAnAction()
        {
            return Content("Hello World!");
        }

        public ActionResult HelloUser(string alpha)
        {
            return Content($"Hello {Server.HtmlEncode(alpha)}");
        }
    }
}