using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_project
{
    public class GasEngineCar : Car
    {
        public GasEngineCar(int price, int yearOfCreation, double kilometrage, EColor color, Efirm firm) :
            base(price, yearOfCreation, kilometrage, color, firm)
        {
        }

        public override string GetCarType()
        {
            return "gas";
        }
    }

    public class ElectricCar : Car
    {
        public ElectricCar(int price, int yearOfCreation, double kilometrage, EColor color, Efirm firm) :
            base(price, yearOfCreation, kilometrage, color, firm)
        {
        }

        public override string GetCarType()
        {
            return "electric";
        }
    }

    public class HybridCar : Car
    {
        public HybridCar(int price, int yearOfCreation, double kilometrage, EColor color, Efirm firm) :
            base(price, yearOfCreation, kilometrage, color, firm)
        {
        }

        public override string GetCarType()
        {
            return "hybrid";
        }
    }
}
