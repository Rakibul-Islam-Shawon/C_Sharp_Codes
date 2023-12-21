using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace else_If_statement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1 , 2 or 3: ");
            string userValue = Console.ReadLine();
            /* string message = "";*/

            /*if (userValue == "1")
            {
                message = "You won a new car. ";

            }

            else if (userValue == "2")
            {
                message = "You won a boat !";

            }

            else if (userValue == "3")
            {
                message = "You won a cat!";
            }

            else
            {
                message = "Sorry, we didn't understand";

            }*/

            //string message = (userValue == "1") ? "you won " : "Wrong info ";
            string message = (userValue == "1") ? "Horse " : "Nothing ";

            //Console.WriteLine(message);

            //Console.WriteLine("You won a {0}. ", message); //As in programming 0 is initial position instead of 1
            Console.WriteLine("You entered {0}. You won {1}", userValue, message);
            
            Console.ReadLine();
        }
    }
}
