using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileIteration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool displayMenu = true;

            while(displayMenu == true)
            {
                displayMenu = MainMenu();
            }
        }

        private static bool MainMenu()
        {
            Console.WriteLine("Choose an Option: ");
            Console.WriteLine("1) Option 1");
            Console.WriteLine("2) Option 2");
            Console.WriteLine("3) Exit");

            string result = Console.ReadLine();

            if(result == "1")
            {
                PrintNumbers();
                return true;
            }
            else if (result == "2")
            {
                GussingNumbers();
                return true;
            }

            else if (result == "3")
            {
                return false;
            }

            else
            {
                return true;
            }
        }

        private static void PrintNumbers()
        {
            Console.WriteLine("Print numbers!");
            Console.Write("Type a number: ");

            int result = int.Parse(Console.ReadLine());
            int counter = 1;

            while(counter < result + 1)
            {
                Console.Write(counter);
                Console.Write("-");
                counter++;
            }

            Console.ReadLine();
        }

        private static void GussingNumbers()
        {
            Console.WriteLine("Gussing Number");

            Console.ReadLine();
        }



    }
}
