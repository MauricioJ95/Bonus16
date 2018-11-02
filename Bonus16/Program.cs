using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus16
{
    class Program
    {
        static void Main(string[] args)
        {   //calling my class and naming it app
            CarApp app = new CarApp();

            app.carInfo();
            //calling my constructors 
            app.displayCars();

            Console.ReadKey();
        }
    }
}
