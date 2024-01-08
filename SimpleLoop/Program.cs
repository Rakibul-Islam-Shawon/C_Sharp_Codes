using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace SimpleLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 100;

            for(int i = 0; i< 200; i++)
            {
               // Console.WriteLine(i);

                if(i == a)
                {
                    Console.WriteLine("Now the two value is same");
                    break;
                }


            }
            Console.ReadLine();
        }
    }
}
