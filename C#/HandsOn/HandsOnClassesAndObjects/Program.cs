using System;

namespace HandsOnClassesAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //create student object
            Student s1 = new Student();
            s1.studentId = 3432;
            s1.studentName = "Aniket";
            s1.dob = DateTime.Parse("12.2.2013");
            s1.std = "III";
            s1.Show();
            Console.WriteLine();
            Student s2 = new Student() { studentId = 430349, 
                studentName = "Harsit", std = "II", dob = new DateTime(2017, 2, 23) }; //object initializer
            s2.Show();
            Student s3 = new Student() { studentId = 3453, studentName = "Hareesh", std = "II", dob = DateTime.Parse("12.2.2000") };
            s3.Show();
            ////Student Array
            Student[] students = new Student[3];
            students[0] = new Student() { studentId = 342983, studentName = "Riyaz", 
                dob = new DateTime(2010, 11, 23), std = "V" };
            students[1] = new Student() { studentId = 342984, studentName = "Aman", 
                dob = new DateTime(2010, 4, 23), std = "IV" };
            students[2] = s3;
            foreach (var s in students)
            {
                s.Show();
            }

        }
    }
}
