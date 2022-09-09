using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HandsOnModels.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime JoinDate { get; set; }
        public string Designation { get; set; }
        public int Salary { get; set; }
    }
}