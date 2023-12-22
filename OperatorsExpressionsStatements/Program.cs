using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsExpressionsStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Variable declaration
            int x, y, a, b;

            //  Assignment Operator
            x = 3;
            y = 4;
            a = 5;
            b = 6;

            //Mathematical Operators......

            //Addition Operators
            x = 3 + 4;

            //Subtraction Operator
            x = 30 - 40;

            //Multiplication Operator
            x = 3 * 5;

            //Division Operator
            x = 6 / 2;


            // Order of Operations using parenthesis
            x = (x + y) * (a - b);


            // There are many operators used to evaluate values.........

            // Equality Operator
            if( x == y)
            {

            }

            //Greater than operator
            if(x > y)
            {

            }

            //Less than Operator
            if(x < y)
            {

            }

            // Greater or Equal to Operator

            if( x >= y)
            {

            }

            //Less than or Equal to Operator

            if( x  <= y)
            {

            }


            //There are two "conditional" Operators as well that can be used
            //to expand / enhance an evaluation... and they can be combined together multiple times.


            // Conditional AND Operator

            if( (a > b) && (a > x))
            {

            }

            //Conditional OR Operator

            if( ( a > b) || (a > y))
            {

            }

            // In-Line Conditional Operator

            string message = (x == 1) ? "Car" : "Boat";

            //Member access and Method invocation

            Console.WriteLine("HELLO");

        }
    }
}
