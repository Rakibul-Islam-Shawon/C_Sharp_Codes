﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsStatment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            /*while(i < 5)
            {
                Console.WriteLine(i);
                i++;
            }*/

            /*do
            {
                Console.WriteLine(i + 1);
                i++;
            } while (i < 5000);*/


            /* for( int j = 0; j <=10; j++)
             {
                 Console.WriteLine(j);
             }*/

            for (int j = 10; j >= 1; j--)
            {
                Console.WriteLine(j * 2);
            }




            Console.ReadLine();
        }
    }
}
