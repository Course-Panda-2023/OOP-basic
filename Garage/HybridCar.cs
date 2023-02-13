using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class HybridCar : Car
    {
        private CarType carType { get; set; }
        public HybridCar(double price, uint yearOfMade, uint kilometers, Color color, string firm) : base(price, yearOfMade, kilometers, color, firm)
        {
            carType = CarType.Hybrid;
        }

        public override void PrintCarDetails()
        {
            Console.WriteLine("This is hybrid car");
        }
    }
}
