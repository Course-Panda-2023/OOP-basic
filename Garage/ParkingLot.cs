using System;
using System.Collections.Generic;

class ParkingLot
{
    private List<Car> cars;

    public ParkingLot()
    {
        cars = new List<Car>();
    }

    public ParkingLot(List<Car> cars)
    {
        this.cars = cars;
    }

    public void AddCar(Car car)
    {
        cars.Add(car);
    }

    public void RemoveCar(Car car)
    {
        if (cars.Count > 0 && cars.Contains(car))
        {
            cars.Remove(car);
        }
        else
        {
            Console.WriteLine("Car is not in parking lot");
        }
    }

    public void GetInfo(Car car)
    {
        if (cars.Contains(car) && cars.Count != 0)
        {
            Console.WriteLine("Price: " + car.Price.ToString() + ", Year: " + car.Year.ToString() + ", Kilometrage: " + car.Kilometrage.ToString() + ", Color: " + car.Color.ToString() + ", Firm: " + car.Firm.ToString());
        }
        else
        {
            Console.WriteLine("List doesn't contain car");
        }
    }

    private void PrintType(String type)
    {
        Type t;
        if (type == "Gas")
        {
            t = GasCar;
        }
        else if (type == "Electric")
        {
            t = ElectricCar;
        }
        else if (type == "Hybrid")
        {
            t = HybridCar;
        }

        foreach (Car car in cars)
        {
            if (ReferenceEquals(car.GetType(), typeof(t)))
            {
                Console.WriteLine("Car number: " + i + " "); //Prints the index of the opropriate car
            }
            i++;
        }
    }

    public void PrintCarOfType(string type)
    {
        int i = 1;
        switch (type)
        {
            case "Gas":
                PrintType("Gas");
                break;
            case "Electric":
                PrintType("Electric");
                break;
            case "Hybrid":
                PrintType("Hybrid");
                break;
            default:
                Console.WriteLine("Invalid car type");
                break;
        }
    }

    public void OfColor(string color)
    {
        int i = 1;
        foreach (Car car in cars)
        {
            if (car.Color == color)
            {
                Console.WriteLine("Car number: " + i + " "); //Prints the index of the opropriate car
            }
            i++;
        }
    }
    public void afterYear(int year)
    {
        int i = 1;
        foreach (Car car in cars)
        {
            if (car.Year > year)
            {
                Console.WriteLine("Car number: " + i + " "); //Prints the index of the opropriate car
            }
            i++;
        }
    }
}
