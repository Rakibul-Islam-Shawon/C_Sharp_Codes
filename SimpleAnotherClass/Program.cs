using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAnotherClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Addition a = new Addition();

            Console.WriteLine(a.add());
        }
    }

    public class Addition
    {
        public int a = 10;
        public int b = 20;  

        public int add()
        {
            return a + b;
        }
        
    }
}
