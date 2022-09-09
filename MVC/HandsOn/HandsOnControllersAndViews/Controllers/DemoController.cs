using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnControllersAndViews.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Welcome() //Action method
        {
       
            return View();
        }
        public ActionResult Greet()
        {
            return View();
        }
    }
}