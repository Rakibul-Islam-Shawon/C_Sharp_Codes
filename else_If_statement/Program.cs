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
            string message = "";

            if (userValue == "1")
            {
                 message = "You won a new car. ";
               
            }

            else if(userValue == "2")
            {
                 message = "You won a boat !";
               
            }

            else if(userValue == "3")
            {
                 message = "You won a cat!";
            }

            else
            {
                 message = "Sorry, we didn't understand";
                
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
