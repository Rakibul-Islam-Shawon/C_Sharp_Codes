﻿using System;
using System.Collections.Generic;
using System.Linq;
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

            if (userValue == "1")
            {
                string message = "You won a new car. ";
                Console.WriteLine(message);
            }

            else if(userValue == "2")
            {
                string message = "You won a boat !";
                Console.WriteLine(message);
            }

            else if(userValue == "3")
            {
                string message = "You won a cat!";
                Console.WriteLine(message);
            }

            else
            {
                string message = "Sorry, we don't understand";
                Console.WriteLine(message);
            }


            Console.ReadLine();
        }
    }
}
