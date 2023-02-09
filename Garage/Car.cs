using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    abstract class Car
    {
        private string id;
        private int price;
        private int yearOfProduction;
        private int kilometraj;
        private string color;
        private string firma;

        public string Id { get { return id; } }

        public abstract String printCarType();

        public void PrintInfo()
        {
            Console.WriteLi("The properties of car with id " + this.id + " are:\n" +
                $"price: {this.price}\n" +
                $"year of production: {this.yearOfProduction}\n" +
                $"kilometers traveled: {this.kilometraj}\n" +
                "color: " + this.color + "\n" +
                "firma: " + this.firma + 
                "the car type is: " + this.printCarType());
        }
        public String getColor()
        {
            return this.color;
        }
        public int getYearOfProduction()
        {
            return this.yearOfProduction;
        }
    }
}