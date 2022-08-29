using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnLinq
{
    class Demo1
    {
        static void Main()
        {
            string[] flowers = { "Rose", "Lilly", "Jasmine", "Tulips" };
            //Fileter flowers with lenght >4
            var result = from f in flowers
                         where f.Length > 4
                         orderby f.Length ascending
                         select f.ToUpper();
            foreach (var item in result)
                Console.WriteLine(item);
        }
    }
}
