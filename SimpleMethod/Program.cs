using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HelloWorld();

            Console.WriteLine(Summation());
            Console.ReadLine();
        }

        /*private static void HelloWorld()
        {
            Console.WriteLine("Hello World! ");
        }*/

        private static int Summation()
        {
            int a = 20;
            int b = 20;

            return (a + b);

        }
        
    }
}
