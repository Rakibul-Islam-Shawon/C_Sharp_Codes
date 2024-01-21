using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            car1.Make = "Oldmobile";
            car1.Model = "Cutlas Supreme";

            Car car2 = new Car();
            car2.Make = "Geo";
            car2.Model = "Prism";

            Book b1 = new Book();
            b1.Author = "Robert Tabor";
            b1.Title = "Microsoft .Net XML Web Services";
            b1.ISBN = "0-000-00000-0";

            /*
             * 
             * Old Style arraylist
            ArrayList myArrayList = new ArrayList();

            myArrayList.Add(car1);
            myArrayList.Add(car2);
            myArrayList.Add(b1);

            foreach(Car car in myArrayList)
            {
                Console.WriteLine(car.Make);

            }
            */

            List<Car> myList = new List<Car>();

            myList.Add(car1);
            myList.Add(car2);

            foreach (Car car in myList)
            {
                Console.WriteLine(car.Model);
            }

            Console.ReadLine();
        }
    }

    class Car
    {
        public string Make {  get; set; }
        public string Model { get; set; }


    }

    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }

    }
}
