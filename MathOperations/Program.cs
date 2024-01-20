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
            Console.ReadLine();
        }
    }
}
