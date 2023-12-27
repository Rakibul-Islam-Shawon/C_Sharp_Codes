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

            //string myString = String.Format("{0:C}", 123.45); //:C is a format character use for Currency

            //string myString = String.Format("{0:N}", 1254785545844); //:N is for formating with comma and decimal position

            // string myString = String.Format("Percentage: {0:P}", .123); //:P is used for percentage

            //string myString = String.Format("Phone Number: {0:(####) ### ####}", 017212312311);

            string myString = "  That summer we took threes across the board ";

            // myString = myString.Substring(6, 14);

            // myString = myString.ToUpper();

            //myString = myString.Replace(" ", "--");

            myString = myString.Remove(8, 11);


            Console.WriteLine(myString);
            Console.ReadLine();
        }
    }
}
