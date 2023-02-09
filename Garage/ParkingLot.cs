using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP-Basic
{
    public class ParkingLot
    {
        protected List<Car> cars = new List<Car>();

        public void AddCar(Car newCar)
        {
            cars.Add(newCar);
        }

        public void AddCar(double price, int year, int km, string color, string company, string type)
        {
            Car newCar;
            switch (type)
            {
                case Constants.GAS_TYPE:
                    cars.Add(new GasCar(price, year, km, color, company));
                    break;
                case Constants.ELECTRIC_TYPE:
                    cars.Add(new ElectricCar(price, year, km, color, company));
                    break;
                case Constants.HYBRID_TYPE:
                    cars.Add(new HybridCar(price, year, km, color, company));
                    break;
                default:
                    break;
            }                
        }

        public Car GetCatAt(int index)
        {
            return this.cars.ElementAt(index);
        }

        public void PrintCarInfo(int index)
        {
            this.GetCatAt(index).PrintInfo();
        }

        public void PrintByType(string type)
        {
            foreach (Car car in this.cars)
            {
                if (car.Type == type)
                    car.PrintInfo();
            }
        }

        public void PrintByColor(string color)
        {
            foreach (Car car in this.cars)
            {
                if (car.Color == color)
                    car.PrintInfo();
            }
        }

        public void PrintByYear(int year)
        {
            foreach (Car car in this.cars)
            {
                if (car.Year >= year)
                    car.PrintInfo();
            }
        }
    }
}
