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

            Console.Write("What is your Middle name: ");
            string mName = Console.ReadLine();

            Console.WriteLine("What is your Last Name: ");
            string lName = Console.ReadLine();

            Console.WriteLine("What is your Adress: ");
            string adressName = Console.ReadLine();

            Console.WriteLine("Congratiolations ! {0} {1} {2} , Your are a programmer1", fName,mName, lName);
            Console.WriteLine("Your address is : {0} ",adressName);
            Console.ReadLine();
        }
    }
}
