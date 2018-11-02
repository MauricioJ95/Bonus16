using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    public class CarApp
    {
        List<Car> Cars = new List<Car>();
        public void carInfo()
        {

            int numberOfCars = 0;
            int year = 0;
            double price = 0;
            string  make = "", model = "";

            Console.WriteLine("Enter the number of cars you'd like to make.");
            numberOfCars = int.Parse(Console.ReadLine());
            for (int c = 0; c < numberOfCars; c++)
            {
                Console.WriteLine("Please enter the make.");
                make = Console.ReadLine();

                Console.WriteLine("Please enter the model.");
                model = Console.ReadLine();

                Console.WriteLine("Please enter the year.");
                year = int.Parse(Console.ReadLine());

                Console.WriteLine("Please enter the price");
                price = double.Parse(Console.ReadLine());
                Cars.Add(new Car(make, model, year, price));
            }
        }
        public void displayCars()
        {
            Console.WriteLine($"\tMake\tModel\tYear\tPrice");
            Console.WriteLine();
            foreach (Car car in Cars)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}


