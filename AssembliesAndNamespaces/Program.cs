using System;
using System.IO;
using System.Net;
using static System.Net.Mime.MediaTypeNames;

namespace AssembliesAndNamespaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
                //string text = "A class is the most powerful data type in C#. ";

            //File.WriteAllText(@"E:\2019-Programming Lang\C#\WriteText.txt", text);

            WebClient client = new WebClient();
            string reply = client.DownloadString("http://msdn.microsoft.com");

            Console.WriteLine(reply);
            File.WriteAllText(@"E:\2019-Programming Lang\C#\WriteText.txt", reply);
            Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
    }
}
