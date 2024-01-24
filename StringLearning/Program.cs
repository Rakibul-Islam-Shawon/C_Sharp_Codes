using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper());   // Outputs "HELLO WORLD"
            Console.WriteLine(txt.ToLower());   // Outputs "hello world"

            */


            /*
            string myString = "Hello";
            Console.WriteLine(myString.IndexOf("e"));

            */


            string firstName = "John";
            string lastName = "Doe";
            string name = $"My full name is: {firstName} {lastName}";
            Console.WriteLine(name);
        }
    }
}
