using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate int CubeDelegate(int i);
    internal class Demo4
    {
        public static int Cube(int i)
        {
            return i * i * i;
        }
        static void Main()
        {
            CubeDelegate c1 = new CubeDelegate(Cube);
            Console.WriteLine(c1(2));
            CubeDelegate c2 = delegate (int i) //anonymous function
            {
                return i * i * i;
            };
            Console.WriteLine(c2(7));
            CubeDelegate c3 = i => i * i * i; //lambda expression
            Console.WriteLine(c3(5));
            CubeDelegate c4 = i =>
            {
                int result = i * i * i;
                return result;
            };//lambda expression
        }
    }
}
