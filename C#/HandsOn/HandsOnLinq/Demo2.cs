using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    internal class Demo2
    {
        static void Main()
        {
            List<int> list = new List<int>() { 12, 21, 23, 32, 45, 33, 44, 67, 78, 89, 98, 87, 76, 54 };
            //immediate execution
            var result = from l in list
                         where l > 30
                         orderby l descending
                         select l;
            foreach (var item in result)
                Console.WriteLine(item);
            var result1 = from l in list
                          let k = l * l
                          where k > 300
                          orderby k descending
                          select k;
            //return even values in list form
            //immediate execution
            List<int> l1= (from l in list
                          where l%2==0
                          orderby l descending
                          select l).ToList();
            foreach (var item in l1)
                Console.WriteLine(item);
        }
    }
}
