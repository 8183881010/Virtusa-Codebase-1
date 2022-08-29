using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    class Enroll
    {
        public string CName { get; set; }
        public int Id { get; set; }  //Id is nothing but StudentId
    }

    internal class Demo7
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student(){Id=1,Name="Kamal"},
                 new Student(){Id=2,Name="Guna"},
                  new Student(){Id=3,Name="Jaya"},
            };
            List<Enroll> enrolls = new List<Enroll>()
            {
                new Enroll(){CName="C#",Id=1},
                 new Enroll(){CName="C#",Id=2},
                  new Enroll(){CName="C#",Id=3},
                   new Enroll(){CName="React",Id=1},
                    new Enroll(){CName="Anguar",Id=2},
                     new Enroll(){CName="Vue",Id=3}
            };
            var result = from s in students
                         join e in enrolls
                         on s.Id equals e.Id
                         select new { Id = s.Id, Name = s.Name, CName = e.CName};
            foreach (var item in result)
            {
                Console.WriteLine($"ID:{item.Id} Name:{item.Name} Course:{item.CName}");
            }
            Console.WriteLine();
            //Grouping
            var result1 = from s in students
                          join e in enrolls
                          on s.Id equals e.Id
                          group new { s.Id, s.Name, e.CName } by s.Name;
            foreach (var collection in result1)
            {
                Console.WriteLine("{0} Enrolled Courses", collection.Key); //key retunr group by property value
                foreach (var item in collection)
                    Console.WriteLine($"Course Name:{item.CName}");
            }
            Console.WriteLine();
            var result2 = from s in students
                          join e in enrolls
                          on s.Id equals e.Id
                          group new { s.Id, s.Name, e.CName } by e.CName;
            foreach (var collection in result2)
            {
                Console.WriteLine("{0} Enrolled Students", collection.Key); //key retunr group by property value
                foreach (var item in collection)
                    Console.WriteLine($"Course Name:{item.Name}");
            }
            ////Select into
            //var result2 = from s in students
            //              join e in enrolls
            //              on s.Id equals e.Id
            //              select new { s.Id, s.Name, e.CName } into es
            //              group es by es.Name;
            //foreach (var collection in result1)
            //{
            //    Console.WriteLine("{0} Enrolled Courses", collection.Key); //key retunr group by property value
            //    foreach (var item in collection)
            //        Console.WriteLine($"Course Name:{item.CName}");
            //}
        }
    }
}
