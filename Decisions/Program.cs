using System;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bob's Big Giveaway");
            Console.Write("Choose a door: 1 , 2 or 3: ");
            string userValue = Console.ReadLine();
            string message = "";

            if(userValue == "1")
            {
                message = "You won a new car. ";
                
            }
            else if(userValue == "2")
            {
                message = "You won a new bike";
            }
            else
            {
                message = "You won a new cycle";
            }

            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
