using System;
using System.IO;

namespace AssembliesAndNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "A class is the most powerful data type in C#. ";

            File.WriteAllText(@"E:\2019-Programming Lang\C#\WriteText.txt", text);

            Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
    }
}
