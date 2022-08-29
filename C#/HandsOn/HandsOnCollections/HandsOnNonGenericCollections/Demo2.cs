using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }

    class Demo2
    {
        static void Main()
        {
            ArrayList list = new ArrayList()
            {
                new Student(){Sid=1,Sname="Rohan",Age=10},
                new Student(){Sid=2,Sname="Karan",Age=10},
                new Student(){Sid=3,Sname="Monica",Age=10},
                new Student(){Sid=4,Sname="Jeson",Age=10},
                new Student(){Sid=5,Sname="Joy",Age=10},
                new Student(){Sid=6,Sname="Jim",Age=10},
            }; //collection initializeer
            Student s1 = new Student() { Sid = 7, Sname = "Ram", Age = 10 };
            list.Add(s1);
            foreach(Student item in list)
            {
                Console.WriteLine($"ID:{item.Sid} Name:{item.Sname} Age:{item.Age}");
            }
        }
    }
}
