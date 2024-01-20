using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssembliesAndNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "A class is the most powerful data type in C#. ";

            System.IO.File.WriteAllText(@"E:\2019-Programming Lang\C#\WriteText.txt", text);

            Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
    }
}
