using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public abstract class Car
    {
        public int YearOfMake { get; }
        public int Price { get; }
        public int Km { get; }
        public string Color { get; }
        public string Manifactur { get; }

        protected Car(int price, int yearOfMake, int km, string color, string manifactur)
        {
            this.Price = price;
            this.YearOfMake = yearOfMake;
            this.Km = km;
            this.Color = color;
            this.Manifactur = manifactur;
        }
    }
}
