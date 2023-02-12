using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    internal abstract class Car
    {
        protected double price;
        protected int year;
        protected double kilometers;
        protected string color;
        protected string firm;
        protected string engine="";

        public Car(double price, int year,double kilometers,string color,string firm) {
            this.price = price; 
            this.year = year;   
            this.kilometers = kilometers;
            this.color = color; 
            this.firm = firm;   
        }

        virtual public void print()
        {
            Console.WriteLine("-----------------\n" + "price: " + price + "\nyear: " + year + "\nkilometers: " + kilometers + "\ncolor :" + color + "\nfirm :" + firm + "\nengine :"+engine) ;
        }


        virtual public string getColor()
        {

            return color;   
        }

        virtual public int getYear()
        {

            return year;
        }

        virtual public string getEngine()
        {
            return engine;  

        }

    }
}
