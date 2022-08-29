using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandsOnExceptiosn
{
    class Demo1
    {
        static void Main()
        {
            try
            {
                int a = int.Parse(Console.ReadLine());
                int b = int.Parse(Console.ReadLine());
                int result = 0;
               
                
                   result = a / b;
                

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
                //Console.WriteLine("b shold not be 0");
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch(Exception ex) //handle all the types of exceptions.
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }
    }
}
