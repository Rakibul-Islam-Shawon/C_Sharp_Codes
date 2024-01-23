using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IfElseProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter the value of a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            if (a > b)
            {
                Console.WriteLine("A greater than B");

            }
            else if (a == b)
            {
                Console.WriteLine("A is similar to B");
            }
            else if( a < b)
            {
                Console.WriteLine("B greater than A");
            }
            else
            {
                Console.WriteLine("You put wrong information.Please enter right informatin.");
            }



            Console.WriteLine();

        }
    }
}
