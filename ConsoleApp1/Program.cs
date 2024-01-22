using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringandDiscussion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*string hello = "Hello world this is Hanry.";

            Console.WriteLine(hello.Length);
            Console.WriteLine(hello.ToUpper());
            Console.WriteLine(hello.ToLower());
            Console.WriteLine(hello + " You are a nice person.");
            */

            /*
            string name = Console.ReadLine();
            string candies = Console.ReadLine();

            Console.WriteLine($"Your name is {name}. You will get {candies} candies");
            */

            string hello = "Assalamu Alaikum, How are you";
            Console.WriteLine(hello[2]);

            Console.WriteLine(hello.IndexOf("Alaikum"));

            Console.ReadLine();

        }
    }
}
