using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void PrintDelegate();
    public delegate void GreetDelegate(string name);
    internal class Demo3
    {
        static void Main()
        {
            PrintDelegate p1 = delegate () //anonymous function
            {
                Console.WriteLine("Print Something");
            };
            p1(); //calling delegate
            GreetDelegate g1 = delegate (string n)
            {
                Console.WriteLine("Hello " + n);
            };
            g1("Rahul");

            GreetDelegate g2 = n => //lambda expression
            {
                Console.WriteLine("Good Evening "+n);
            };
            //calling g2
            g2("Rajeev");
            PrintDelegate p2 = () => { Console.WriteLine("I am doing something.."); };
        }
    }
}
