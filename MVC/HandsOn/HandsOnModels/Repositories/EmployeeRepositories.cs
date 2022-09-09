using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using HandsOnModels.Models;
namespace HandsOnModels.Repositories
{
    public class EmployeeRepositories
    {
        public static List<Employee> employees = new List<Employee>()
        {
            new Employee(){EmployeeId=1,Name="Raj",JoinDate=DateTime.Parse("2.2.2022"),Salary=45000,Designation="Programmer"},
            new Employee(){EmployeeId=2,Name="Jeevan",JoinDate=DateTime.Parse("2.2.2022"),Salary=45000,Designation="Programmer"}
        };
        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }
        public List<Employee> GetEmployees()
        {
            return employees;
        }
        public Employee GetEmployee(int id)
        {
            return employees.Single(e => e.EmployeeId == id);
        }
       
    }
}