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

            Console.Write("Your Phone Number please: ");
            string PhoneNumber = Console.ReadLine();

            Console.Write("Your ID please: ");
            string ID = Console.ReadLine();

            


            Console.WriteLine("Your name is: {0}\n and your Address is: {1}.\n Your Phone Number: {2}, Your Id: {3}",
                Name, Address, PhoneNumber, ID);
            Console.ReadLine();
        }
    }
}
