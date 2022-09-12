using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HandsOnMVCUsingModelValidation.Models;
namespace HandsOnMVCUsingModelValidation.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(Login login)
        {
            if (ModelState.IsValid) //IsValid retunrs truen when Model is validated
            {
                //validate used with Db table using EntityFramework
                // return RedirectToAction("Index", "Home");
                return Json(login);
            }
            else
                return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    //add employee details to db table
                    return Json(employee);
                }
                else
                    return View();
            }
            catch (Exception ex)
            {

                return View("Error");
            }
        }
       
    }
}