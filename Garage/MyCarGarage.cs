using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    internal class MyCarGarage
    {
        private List<Car> myCarGarage = new List<Car>();


        public List<Car> allCars()
        {
            return myCarGarage; 
        }
        //public void printList(List<Car> list)
        //{
        //    foreach(Car car in list) 
        //    {
        //        car.print();
        //    }
        //}
        public void addCar(Car car)
        {
            myCarGarage.Add(car);   
        }

        public List<Car> getCarsByEngine(string engine) 
        {
            List<Car> ret = new List<Car>();
            foreach(Car car in myCarGarage)
            {
                if (car.getEngine().Equals(engine))
                {
                    ret.Add(car);
                }
            }
            return ret;
        
        }

        public List<Car> getCarsByColor(string color)
        {
            List<Car> ret = new List<Car>();
            foreach (Car car in myCarGarage)
            {
                if (car.getColor().Equals(color))
                {
                    ret.Add(car);
                }
            }
            return ret;

        }

        public List<Car> getCarsByYear(int year)
        {
            List<Car> ret = new List<Car>();
            foreach (Car car in myCarGarage)
            {
                if (car.getYear()>=year)
                {
                    ret.Add(car);
                }
            }
            return ret;

        }



    }
}
