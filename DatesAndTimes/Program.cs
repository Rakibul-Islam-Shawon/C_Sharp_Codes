﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatesAndTimes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime myValue = DateTime.Now;

            //Console.WriteLine(myValue.ToString());
            //Console.WriteLine(myValue.ToShortDateString());
            //Console.WriteLine(myValue.ToShortTimeString());
            //Console.WriteLine(myValue.ToLongDateString());
            //Console.WriteLine(myValue.ToLongTimeString());

            //Console.WriteLine(myValue.AddDays(2).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
            //Console.WriteLine(myValue.AddDays(-1).ToLongDateString());
            //Console.WriteLine(myValue.AddHours(-3).ToLongTimeString());


            //Console.WriteLine(myValue.Month);

            //DateTime myBirthday = new DateTime(1994, 10, 18);
            //Console.WriteLine(myBirthday.ToShortDateString());
            DateTime myBirthday = DateTime.Parse("12/10/1994");
            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);

            Console.WriteLine(myAge.TotalMinutes);
            Console.WriteLine(myAge.TotalDays);


            Console.ReadLine();
        }
    }
}
