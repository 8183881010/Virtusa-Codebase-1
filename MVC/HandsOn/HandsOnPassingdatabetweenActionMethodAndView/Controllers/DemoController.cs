using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HandsOnPassingdatabetweenActionMethodAndView.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult Greet()
        //{
        //    string username = "Jeevan";
        //    //set value in ViewData
        //    ViewData["un"] = username;
        //    return View();
        //}
        public ActionResult Greet(string name)
        {
            string username = name;
            //set value in ViewData
            ViewData["un"] = username;
            return View();
        }
        public ActionResult GetFlowers()
        {
            List<string> flowers = new List<string>() { "Rose","Lilly","Jasmine","Tulips" };
            ViewData["fl"] = flowers;
            return View();
        }
        public ActionResult GetCities()
        {
            ViewBag.Cities = new List<string>() { "Delhi", "Mumbai", "Chennai", "Pune", "Bangalore", "Hyderabad" };
            return View();

        }

    }
}