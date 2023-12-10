using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiplication_of_Two_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = 12;
            int number2 = 14;
            int number3 = 17;

            int mul_result = number1 * number2 * number3;

            Console.WriteLine("The result is: " + mul_result);
            Console.ReadLine();
        }
    }
}
