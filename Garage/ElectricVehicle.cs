using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    class ElectricVehicle : Vehicle
    {
        private const string type = "Electric";
        public ElectricVehicle(double price, int year, int mileage, string color, string brand) : base(price, year, mileage, color, brand)
        {
        }
        public override string ToString()
        {
            return "Type: " + type + " " + base.ToString();
        }
    }
}
