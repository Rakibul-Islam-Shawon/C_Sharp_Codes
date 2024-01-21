using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int result = Math.Max(34, 345);

            Console.WriteLine(result);

            int min_result = Math.Min(24, 343);
            Console.WriteLine(min_result);


            double sqrt_result = Math.Sqrt(36);
            Console.WriteLine(sqrt_result);


            int absolute_result = Math.Abs(-39);
            Console.WriteLine(absolute_result);

            Console.ReadLine();
        }
    }
}
