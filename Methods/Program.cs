using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
    internal class Program
    {
        static void Greet(string name)
        {
            Console.WriteLine("Good Morning." + name);
        }
        static void Main(string[] args)
        {
            Greet("Rakib");

            Console.ReadLine();
        }
    }
}
