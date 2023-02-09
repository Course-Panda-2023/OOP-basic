using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP-Basic
{
    public abstract class Car
    {
        protected double price;
        public double Price { get { return price; } }
        
        protected int year;
        public int Year { get { return year; } }

        protected int km;
        public int Km { get { return km; } }

        protected string color;
        public string Color { get { return color; } }

        protected string company;
        public string Company { get { return company; } }

        protected string type;
        public string Type { get { return type; } }

        protected Car(double price, int year, int km, string color, string company)
        {
            this.price = price;
            this.year = year;
            this.km = km;
            this.color = color;
            this.company = company;
        }

        public virtual void PrintInfo()
        {
            Console.WriteLine($"Price={this.price}\nYear={this.year}\nKm={this.km}\nColor={this.color}\nCompany={this.company}\nEngine Type={this.type}");
        }
    }

}
