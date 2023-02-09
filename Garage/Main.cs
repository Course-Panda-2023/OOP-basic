using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text.RegularExpressions;

class EX3Main
{
    public static void Main(string[] args)
    {
        Car c1 = new CarGas(75000, 2019, 50000, "white", "Toyota");
        Car c2 = new CarElectric(50000, 2018, 50000, "black", "Mazda");
        Car c3 = new CarElectric(45000, 2017, 50000, "silver", "Mitsubishi");
        Car c4 = new CarElectric(60000, 2016, 50000, "blue", "Subaru");
        Car c5 = new CarHybrid(100000, 2019, 50000, "red", "Chevrolet");
        Car c6 = new CarHybrid(250000, 2020, 50000, "white", "Wolkswagen");
        Car c7 = new CarGas(80000, 2022, 50000, "black", "Renault");
        Car c8 = new CarGas(29000, 2015, 50000, "red", "Toyota");
        Car c9 = new CarElectric(22000, 2017, 50000, "blue", "Mazda");
        Car c10 = new CarHybrid(125000, 2012, 50000, "gold", "Wolkswagen");
        List<Car> list = new List<Car>();
        list.Add(c1);
        list.Add(c2);
        list.Add(c3);
        list.Add(c4);
        list.Add(c5);
        list.Add(c6);
        list.Add(c7);
        list.Add(c8);
        list.Add(c9);
        CarPark cp = new CarPark(list);
        cp.addCar(c10);
        List<Car> carlist = cp.getCarByEngineType(EngineType.Electric);
        foreach (Car car in carlist)
        {
            Console.WriteLine(car.Year);
        }
    }
}