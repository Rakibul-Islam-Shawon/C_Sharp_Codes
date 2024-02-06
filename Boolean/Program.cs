using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*bool _Name = true;*/

            /*bool _Name = false;

            if (_Name)
            {
                Console.WriteLine("The value is true.");
            }
            else
            {
                Console.WriteLine("The value is false.");
            }*/

            bool condition = true;

            if (condition)
            {
                Console.WriteLine("Please change your mind: ");
                condition = false;
            }


            Console.ReadLine();
        }
    }
}
