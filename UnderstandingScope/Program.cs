using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingScope
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string j = "";

            for (int i = 0; i < 10; i++)
            {
                j = i.ToString();

                Console.WriteLine(i);
            }

            Console.WriteLine("Outsid of the for : " + j);
            Console.ReadLine();
        }
    }
}
