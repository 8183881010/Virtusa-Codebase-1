using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace HandsOnNonGenericCollections
{
    class Demo3
    {
        static void Main()
        {
            try
            {
                //Keys are uniqe and not null
                //Hashtable ob = new Hashtable();
                SortedList ob = new SortedList();
                ob.Add(1056, "Priyanka");
                ob.Add(1090, "Sohil");
                ob.Add(1000, "Rohan");
                ob.Add(1023, "Anusha");
                ob.Add(1078, "Laxmitha");
                ob.Remove(1056); //remove the key-value pair
                string ename = ob[1000].ToString(); //convert object ot string
                //access all key-value pairs
                foreach (DictionaryEntry d in ob)
                {
                    Console.WriteLine("ID:{0} Name:{1}", d.Key, d.Value);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
