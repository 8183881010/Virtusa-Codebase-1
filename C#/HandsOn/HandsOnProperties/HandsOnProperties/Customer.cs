using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnProperties
{
    internal class Customer
    {
        private string name;
        private string email;


        public Customer(string name, string email)
        {
            this.name = name;
            this.email = email;
        }
        //Read only properties
        public string Name { get => name; }
        public string Email
        {
            get { return email; }

        }
    }
        class Test_Customer
        {

            static void Main()
            {
                Customer obj = new Customer("Vinod", "vinod@gmail.com");

                Console.WriteLine($"Name{obj.Name} Email:{obj.Email}");
            }

        }

    }
