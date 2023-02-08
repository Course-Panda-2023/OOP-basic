using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cars
{
    public abstract class Car
    {
        private int Price;
        private int YearOfMake;
        private int Km;
        private string color;
        private string manifactur;

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
