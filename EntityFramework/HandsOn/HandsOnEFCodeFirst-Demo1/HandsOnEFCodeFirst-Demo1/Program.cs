using HandsOnEFCodeFirst_Demo1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnEFCodeFirst_Demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Add new student
            SMSDB912Conxt db = new SMSDB912Conxt();
            Student student = new Student() { Name = "Raj", Age = 10, Std = "IV" };
            db.Students.Add(student);
            db.SaveChanges();
        }
    }
}
