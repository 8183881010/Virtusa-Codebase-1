using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptiosn
{
    internal class Demo7
    {
        static void Main()
        {
            try
            {
                int a = 10;
                int b = 0;
                int c = a / b;
                Console.WriteLine(c);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Message: " + ex.Message);
                Console.WriteLine("Method Name: " + ex.TargetSite);
                Console.WriteLine("Project Name: " + ex.Source);
                Console.WriteLine("StacK Details: " + ex.StackTrace);
            }
        }
    }
}
