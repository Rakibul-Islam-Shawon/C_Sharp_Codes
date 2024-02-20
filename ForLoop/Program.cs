using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < 100; i++)
            {
                if (i == 7)
                {
                    Console.WriteLine("Hurray! ");
                    Console.WriteLine("Found seven.");
                }
            }

            for (int myValue = 0; myValue < 120; myValue++)
            {
                Console.WriteLine(myValue);
                if(myValue == 8)
                {
                    Console.WriteLine("Found 8.");
                    Console.WriteLine("We can exit now.");
                    break; 
                }
                
            }
            Console.ReadLine();
        }
    }
}
