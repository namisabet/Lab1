using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class InfoController : Controller
    {
        // GET: Info
        public ActionResult Semester()
        {
            return View();
        }
        public ActionResult Testimonial()
        {
            return View();
        }
    }
}