using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_project
{
    public class Garage
    {
        Dictionary<int, Car> allCars = new Dictionary<int, Car>();
        public void AddCar(Car car)
        {
            allCars.Add(car.carID, car);
        }
        public void RemoveCar(int carID)
        {
            if (allCars.ContainsKey(carID))
                allCars.Remove(carID);
        }
        /// <summary>
        /// prints info of all cars made from that year forward
        /// </summary>
        /// <param name="year"></param>
        public void GetCarsByYear(int year)
        {
            var cars = allCars.Where(l => l.Value.yearOfCreation >= year);
            foreach (var car in cars)
            {
                car.Value.PrintCarInfo();
            }
        }
        public void GetCarsByType(Type type)
        {
            var cars = allCars.Where(l => l.Value.GetType() == type);
            foreach (var car in cars)
            {
                car.Value.PrintCarInfo();
            }
        }
        public void GetCarsByColor(EColor color)
        {
            var cars = allCars.Where(l => l.Value.color == color);
            foreach (var car in cars)
            {
                car.Value.PrintCarInfo();
            }
        }
    }
}
