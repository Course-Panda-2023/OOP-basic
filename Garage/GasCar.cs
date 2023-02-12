using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    internal class GasCar:Car
    {
        public GasCar(double price, int year, double kilometers, string color, string firm) : base(price, year, kilometers, color, firm)
        {
            this.engine = "GasCar";
        }

    }
}
