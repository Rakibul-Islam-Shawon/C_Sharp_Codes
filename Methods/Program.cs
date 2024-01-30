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

        static float Average (int a, int b, int c)
        {
            float sum = a + b + c;

            return sum / 3;
        }
        static void Main(string[] args)
        {
            Greet("Rakib");
            Greet("Shawon");

            Console.WriteLine(Average(3, 6, 2));

            Console.ReadLine();
        }
    }
}
