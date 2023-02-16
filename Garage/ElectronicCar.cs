using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class ElectronicCar : Car
    {
        public ElectronicCar(double price, uint yearOfMade, uint kilometers, Color color, string firm, CarType carType = CarType.Electric) : base(price, yearOfMade, kilometers, color, firm)
        {
            this.carType = carType;
        }

        public override void PrintCarDetails()
        {
            Console.WriteLine("This is electronic car");
        }
    }
}
