using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnGenericCollections
{
    internal class SortedListDemo
    {
        static void Main()
        {
            SortedList<int, string> obj = new SortedList<int, string>()
            {
                [12234] = "Suren",
                [5678] = "Jessi",
                [09089] = "Peter"
            };
            obj.Add(1234, "Rohan");
            string ename = obj[5678];
            foreach (KeyValuePair<int, string> item in obj)
            {
                Console.WriteLine("{0} {1}", item.Key, item.Value);
            }
        }
    }
}
