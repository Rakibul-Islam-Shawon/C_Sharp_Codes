using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputandOutput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What is your first name: ");
            string fName= Console.ReadLine();
            Console.WriteLine("What is your Last Name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("Congratiolations ! {0} {1} , Your are a programmer1", fName, lName);
            Console.ReadLine();
        }
    }
}
