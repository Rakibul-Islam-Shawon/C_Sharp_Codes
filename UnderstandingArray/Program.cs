using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnderstandingArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* int[] numbers = new int[5];

             numbers[0] = 2;
             numbers[1] = 4;
             numbers[2] = 6;
             numbers[3] = 8;
             numbers[4] = 10;

             Console.WriteLine(numbers.Length);
             Console.WriteLine(numbers[2]);
             Console.ReadLine();*/


            string[] names = new string[] { "Rakib", "Shawon", "Rifat", "Sakib", "Arman" };

            /*for (int i = 0; i < names.Length; i++) 
            {
                Console.WriteLine(names[i]);
            }*/


            foreach(string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadLine();



        }
    }
}
