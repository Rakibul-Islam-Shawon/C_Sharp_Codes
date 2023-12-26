using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"So-Called\"life"; //Quation operator

            string myString = "What if I need a \nnew Line";

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
