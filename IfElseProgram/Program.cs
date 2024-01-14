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
            int a = 10;
            int b = 20;

            if (a > b)
            {
                Console.WriteLine("A greater than B");

            }
            else if( a < b)
            {
                Console.WriteLine("B greater than A");
            }
            else
            {
                Console.WriteLine("You put wrong information");
            }



            Console.WriteLine();

        }
    }
}
