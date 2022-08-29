using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnDelegates
{
    public delegate void ListDelegate(List<int> list);
    internal class Demo2
    {
        public static void PrintNumbers(List<int> list)
        {
            foreach(var item in list)
            {
                Console.WriteLine(item);
            }
        }
        public static void Do(ListDelegate listDelegate)
        {
            listDelegate(new List<int> { 1, 2, 3 });
        }
        static void Main()
        {
            Do(PrintNumbers);
        }
    }
}
