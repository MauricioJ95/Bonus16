﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {
            CarApp app = new CarApp();

            app.carInfo();

            app.displayCars();

            Console.ReadKey();
        }
    }
}
