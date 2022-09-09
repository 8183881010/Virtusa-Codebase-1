using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HandsOnModels.Models;
using HandsOnModels.Repositories;
namespace HandsOnModels.Controllers
{
    public class EmployeeController : Controller
    {
        EmployeeRepositories employeeRepositories;
        public EmployeeController()
        {
            employeeRepositories = new EmployeeRepositories();
        }
        // GET: Employee
        public ActionResult GetAll() //GetAllEmployees
        {
            List<Employee> employees=employeeRepositories.GetEmployees();
            return View(employees);
        }
        public ActionResult Details(int id)
        {
            Employee employee = employeeRepositories.GetEmployee(id);
            return View(employee);
        }
        public ActionResult Creaet()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            employeeRepositories.AddEmployee(employee);
            return RedirectToAction("GetAll"); //redirects to GetAll Action
        }
    }
}