using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    class Student
    {
        public int Sid { get; set; }
        public string Sname { get; set; }
        public int Age { get; set; }
    }
    interface IStudentRepository<T>
    {
       void AddStudent(T item);
        List<T> GetStudents();
        T GetStudentById(int id);
    }
    class StudentReposiotry : IStudentRepository<Student>
    {
        List<Student> list = new List<Student>();
        public void AddStudent(Student item)
        {
            list.Add(item);
        }

        public Student GetStudentById(int id)
        {
            foreach(var item in list)
            {
                if(item.Sid==id)
                {
                    return item;
                }
            }
            return null;
        }

        public List<Student> GetStudents()
        {
            return list;
        }
    }
    class ListDemo2
    {
        static void Main()
        {
            StudentReposiotry studentReposiotry = new StudentReposiotry();
            do
            {
                Console.WriteLine("1.AddStudent\n2.GetStudentById\n3.GetAllStudents\n4.Exit");
                Console.WriteLine("Enter choice");
                int ch = int.Parse(Console.ReadLine());
                switch(ch)
                {
                    case 1:
                        {
                            //Add Student
                            Student student = new Student();
                            Console.WriteLine("Enter StudentId");
                            student.Sid = int.Parse(Console.ReadLine());
                            Console.WriteLine("Enter name");
                            student.Sname = Console.ReadLine();
                            Console.WriteLine("Enter Age");
                            student.Age = int.Parse(Console.ReadLine());
                            studentReposiotry.AddStudent(student);
                        }
                        break;
                    case 2:
                        {
                            Console.WriteLine("Enter StudentId");
                            int sid = int.Parse(Console.ReadLine());
                            Student student = studentReposiotry.GetStudentById(sid);
                            if (student != null)
                            {
                                Console.WriteLine($"Id: {student.Sid} Name: {student.Sname} Age: {student.Age}");
                            }
                            else
                                Console.WriteLine("Student Id is not valid");
                        }
                        break;
                    case 3:
                        {
                            List<Student> students = studentReposiotry.GetStudents();
                            foreach(var student in students)
                            {
                                Console.WriteLine($"Id: {student.Sid} Name: {student.Sname} Age: {student.Age}");
                            }
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                }
            } while (true);
        }
    }
}
