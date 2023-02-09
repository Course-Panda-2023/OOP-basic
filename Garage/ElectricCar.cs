using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    class ElectricCar : Car
    {
        public override string printCarType()
        {
            Console.Write("Electric");
            return "Electric";
        }
        public ElectricCar(string id, int price, int yearOfProduction, int kilometraj, string color, string firma)
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