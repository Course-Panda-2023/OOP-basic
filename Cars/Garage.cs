using Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    public class Garage
    {
        private List<Car> cars { get; set; }

        private void PrintCarInfo(Car car)
        {
            Console.WriteLine($"car's manifactor is {car.Manifactur}, it was nade in {car.YearOfMake} and it has {car.Km} km." +
                $"it is painted {car.Color} and it costs {car.Price}");
        }

        private void PrintCarByKind(String carType)
        {
            foreach (Car car in this.cars)
            {
                if (car.GetType().ToString() == carType)
                {
                    PrintCarInfo(car);
                }

            }
        }

        private void PrintCarByColor(String color)
        {
            foreach (Car car in this.cars)
            {
                if (car.Color == color)
                {
                    PrintCarInfo(car);
                }

            }
        }

        private void PrintCarMadeAfterYear(int year)
        {
            foreach (Car car in this.cars)
            {
                if (car.YearOfMake > year)
                {
                    PrintCarInfo(car);
                }

            }
        }

    }
}
