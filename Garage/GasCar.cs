using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    class GasCar : Car
    {
        public override string printCarType()
        {
            Console.Write("Gas");
            return "Gas";
        }

        public GasCar(string id, int price, int yearOfProduction, int kilometraj, string color, string firma)
        {
            this.id = id;
            this.price = price;
            this.yearOfProduction = yearOfProduction;
            this.kilometraj = kilometraj;
            this.color = color;
            this.firma = firma;
        }
    }
}