using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public abstract class Car
    {
        protected int YearOfMake;
        protected int Price;
        protected int Km;
        protected string color;
        protected string manifactur;

        protected Car(int price, int yearOfMake, int km, string color, string manifactur)
        {
            this.Price = price;
            this.YearOfMake = yearOfMake;
            this.Km = km;
            this.color = color;
            this.manifactur = manifactur;
        }
    }
}
