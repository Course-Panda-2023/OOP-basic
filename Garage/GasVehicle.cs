using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    
    class GasVehicle : Vehicle
    {
        private const string type = "Gas";
        public GasVehicle(double price, int year, int mileage, string color, string brand) : base(price, year, mileage, color, brand)
        {
        }
        public override string ToString()
        {
            return "Type: " + type + " " + base.ToString();
        }
    }
    
}
