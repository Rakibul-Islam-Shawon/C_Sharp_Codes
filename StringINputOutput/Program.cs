using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringINputOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Your name please: ");
            string Name = Console.ReadLine();

            Console.Write("Your address please: ");
            string Address = Console.ReadLine();


            Console.WriteLine("Your name is: {0} and your Address is: {1}.", Name, Address);
            Console.ReadLine();
        }
    }
}
