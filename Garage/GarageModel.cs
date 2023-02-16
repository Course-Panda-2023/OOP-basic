using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal class GarageModel
    {
        List<Car> carsInTheGarage = new();

        public List<Car> CarsInTheGarage
        {
            get { return carsInTheGarage;  }
            set { carsInTheGarage = value; }
        }

        public void AddCars(params Car[] cars)
        {
            Span<Car> carsAsSpan = cars.AsSpan();
            for (int i = 0; i < carsAsSpan.Length; ++i)
            {
                carsInTheGarage.Add(carsAsSpan[i]);
            }
        }

        public void AllCarsDetails()
        {
            Span<Car> carsInTheGarageAsSpan = CollectionsMarshal.AsSpan(carsInTheGarage);
            for (int i = 0; i < carsInTheGarageAsSpan.Length; ++i)
            {
                Console.Write($"{i}\t\t");
                Console.WriteLine(carsInTheGarageAsSpan[i].ToString());
            }
        }

        public List<Car> Filter(CarType @enum = CarType.None, Color? color = null, uint yearOfMade = 0)
        {
            List<Car> result = new();
            Span<Car> carsInTheGarageAsSpan = CollectionsMarshal.AsSpan(carsInTheGarage);
            bool[] parametersToConsider = new bool[3];
            parametersToConsider[0] = @enum == CarType.None ? true : false;
            parametersToConsider[1] = color is null ? true : false;
            parametersToConsider[2] = yearOfMade == 0 ? true : false;

            for (int i = 0; i < carsInTheGarageAsSpan.Length; ++i)
            {
                if ((parametersToConsider[0] || carsInTheGarageAsSpan[i].CarType == @enum) && (parametersToConsider[1] || carsInTheGarageAsSpan[i].Color == color) 
                    && (parametersToConsider[2] || carsInTheGarageAsSpan[i].YearOfMade > yearOfMade))
                {
                    result.Add(carsInTheGarage[i]);
                }
            }

            return result;
        }
    }
}
