using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectLifetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car myCar = new Car();

            myCar.Make = "Audi";
            myCar.Model = "1999";
            myCar.Year = 2020;
            myCar.Color = "Silver";

            Console.WriteLine("{0} {1} {2} {3} ", myCar.Make, myCar.Model, myCar.Year, myCar.Color);

            Car myOtherCar = new Car();

            myOtherCar = myCar;
            Console.WriteLine("{0} {1} {2} {3} ", myOtherCar.Make, myOtherCar.Model, myOtherCar.Year, myOtherCar.Color);

            myOtherCar.Model = "98";
            Console.WriteLine("{0} {1} {2} {3} ", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            Console.ReadLine();

            Console.WriteLine("{0} {1} {2} {3} ", myCar.Make, myCar.Model, myCar.Year, myCar.Color);
            Console.ReadLine();

        }
    }

     class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get;set; }


    }
}
