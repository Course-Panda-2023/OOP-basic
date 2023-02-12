using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    internal class ElectricCar:Car
    {
        public ElectricCar(double price, int year, double kilometers, string color, string firm) : base(price, year, kilometers, color, firm)
        {
            this.engine = "ElectricCar";
        }

    }
}
