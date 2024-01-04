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
            Subtraction b = new Subtraction();
            Multiplication c = new Multiplication();
            Division d = new Division();




            Console.WriteLine(a.add());
            Console.WriteLine(b.subtract());
            Console.WriteLine(c.mul());
            Console.WriteLine(d.div());
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

    public class Subtraction
    {
        public int a = 50;
        public int b = 20;

        public int subtract()
        {
            return a - b;
        }

    }

    public class Multiplication
    {
        public int a = 10;
        public int b = 20;

        public int mul()
        {
            return a * b;
        }

    }

    public class Division
    {
        public int a = 100;
        public int b = 20;

        public int div()
        {
            return a / b;
        }

    }
}
