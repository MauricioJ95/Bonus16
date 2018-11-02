using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
     public class Car //my class
    {
        private string make;
        public string Make
        {
            get
            {
                return make;
            }
            set
            {
                make = value;
            }
        }
        private string model;
        public string Model //my getters and setters aka Fields
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        private int year;
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }
        private double price;
        public double Price
        {
            get
            {
                return price;
            }
            set
            {
                price = value;
            }
        }

        public Car()
        {

        }
        public Car(string carMake, string carModel, int carYear, double carPrice) //start of my constructors
        {
            make = carMake;
            model = carModel;
            year = carYear;
            price = carPrice;
        }
        public override string ToString()
        {
            return $"\t{make}\t{model}\t{year}\t{price}";
        }
    }
}
