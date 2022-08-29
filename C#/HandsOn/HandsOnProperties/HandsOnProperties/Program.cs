using System;

namespace HandsOnProperties
{
    class Employee
    {
        private int employeeId;
        private string employeeName;
        //property for employeeId
        public int EmployeeId
        {
            get { return employeeId; } //get always return value of private variable using return
            set { employeeId = value; }
        }
        //property for employeeName
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; }
        }
        public void Details()
        {
            Console.WriteLine("Id:{0} Name:{1}", employeeId, employeeName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.EmployeeId = 1989; //set invokes
            e1.EmployeeName = "Mark"; //set invokes
            e1.Details();
            Employee e2 = new Employee();
            e2.EmployeeId = 432093;
            e2.EmployeeName = "Peter";
            e2.Details();
          
        }
    }
}
