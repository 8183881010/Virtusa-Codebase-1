using System;
using System.Linq;
using System.Collections.Generic;
namespace HandsOnLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] no = { 12, 23, 34, 45, 56, 67, 78, 89 }; //datasource
            //fetch even values
            var result = from i in no
                                      where i % 2 == 0
                                      select i;
            no[1] = 24;
           
            result = from i in no where i > 40 && i%2!=0 select i;
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            var result_sorting = from i in no where i > 30 orderby i select i;
            result_sorting = from i in no where i > 30 orderby i descending select i;

            foreach (var item in result_sorting)
                Console.WriteLine(item);
            Console.ReadKey();

        }
    }
}
