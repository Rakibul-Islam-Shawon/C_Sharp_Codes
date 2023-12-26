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

            //string myString = "What if I need a \nnew Line"; //Escape character

            //string myString = "Go to your c:\\ drive"; //Backslash character as escape sequence

            //string myString = @"Go to your c:\ drive";

            //string myString = String.Format("{0} = {1}", "First", "Second"); //Replacement Code

            string myString = String.Format("{0:C}", 123.45);

            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
