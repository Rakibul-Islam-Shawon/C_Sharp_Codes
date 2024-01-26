using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatement
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int age = 78;

            switch (age)
            {
                case 18:
                    Console.WriteLine("Please wait for an Year");
                    break;

                case 20:
                    Console.WriteLine("You are 20");
                    break;

                default:
                    Console.WriteLine("Enjoy");
                    break;
            }
        }
    }
}
