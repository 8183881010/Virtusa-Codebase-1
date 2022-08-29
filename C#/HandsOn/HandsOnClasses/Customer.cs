using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnClasses
{
    class Customer
    {
        //class-varable
        public int customerId;
        public string customerName;
        public string city;
        //methods
        public void Details()
        {
            Console.WriteLine($"ID:{customerId} Name:{customerName} City:{city}");
        }
        //constructors
        //properties
        //indexers
    }
}
