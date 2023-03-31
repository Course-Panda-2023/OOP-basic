using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_project
{
    public abstract class Car
    {
        static int IDcounter;

        public int price;
        public int yearOfCreation;
        double kilometrage;
        public EColor color;
        Efirm firm;
        public int carID;

        public Car(int price, int yearOfCreation, double kilometrage, EColor color, Efirm firm)
        {
            this.price = price;
            this.yearOfCreation = yearOfCreation;
            this.kilometrage = kilometrage;
            this.color = color;
            this.firm = firm;
            carID = GetCarID();
        }

        private static int GetCarID()
        {
            //lock (Type.GetType("Car"));
            {
                IDcounter += 1;
                return IDcounter;
            }
        }

        public abstract string GetCarType();
        
        public void PrintCarInfo()
        {
            Console.WriteLine($"\ncar id: {carID}\n{color} {GetCarType()} car which was made in {yearOfCreation}\nprice: {price}\nfirm: {firm}\nkilometrage: {kilometrage}KM");
        }
    }

    public enum EColor
    {
        Blue,
        Gray,
        Black,
        Red
    }
    public enum Efirm
    {
        Tesla,
        Mercedes,
        Toyota
    }
}
