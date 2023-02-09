using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Garage
    {
        private List<Car> cars;
        public List<Car> Cars { get { return cars; } }

        public Garage()
        {
            cars = new List<Car>();
        }

        public void AddCar(Car c)
        {
            if (c != null)
            {
                cars.Add(c);
            }
        } 

        public void RemoveCar(Car c)
        {
            for (int i = 0; i< cars.Count; i++)
            {
                if (cars[i].Equals(c))
                    cars.Remove(c);
            }
        }

        public void PrintCarInfo(Car c)
        {
            Console.WriteLine($"Price: {c.price}");
            Console.WriteLine($"Production year: {c.productionYear}");
            Console.WriteLine($"Kilometer: {c.kilometer}");
            Console.WriteLine($"Colour: {c.colour}");
            Console.WriteLine($"Brand: {c.brand}");
            Console.WriteLine();
        }

        public void PrintCarsByType(string type)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].GetType().ToString() == "Garage." + type)
                {
                    PrintCarInfo(cars[i]);
                    Console.WriteLine();
                }
            }
        }

        public void PrintCarsByColour(string colour)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].colour == colour)
                {
                    PrintCarInfo(cars[i]);
                    Console.WriteLine();
                }
            }
        }

        public void PrintCarsByYear(int year)
        {
            for (int i = 0; i < cars.Count; i++)
            {
                if (cars[i].productionYear > year)
                {
                    PrintCarInfo(cars[i]);
                    Console.WriteLine();
                }
            }
        }
    }
}
