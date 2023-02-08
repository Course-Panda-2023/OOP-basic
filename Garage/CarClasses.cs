using System;
using System.Collections.Generic;

abstract class Car
{
    private double price;
    public double Price { get; set; }
    private int year;
    public int Year { get; set; }
    private int kilometrage;
    public int Kilometrage { get; set; }
    private string color;
    public string Color { get; set; }
    private string firm;
    public string Firm { get; set; }

    public Car(double price, int year, int kilometrage, string color, string firm)
    {
        this.price = price;
        this.year = year;
        this.kilometrage = kilometrage;
        this.color = color;
        this.firm = firm;
    }
}
class GasCar : Car
{
    public GasCar(double price, int year, int kilometrage, string color, string firm) : base(price, year, kilometrage, color, firm)
    {
    }
}
class ElectricCar : Car
{
    public ElectricCar(double price, int year, int kilometrage, string color, string firm) : base(price, year, kilometrage, color, firm)
    {
    }
}
class HybridCar : Car
{
    public HybridCar(double price, int year, int kilometrage, string color, string firm) : base(price, year, kilometrage, color, firm)
    {
    }
}

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
        if ((cars.Count > 0) && (cars.Contains(car)))
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
        if ((cars.Contains(car)) && (cars.Count != 0))
        {
            Console.WriteLine("Price: " + car.Price.ToString() + ", Year: " + car.Year.ToString() + ", Kilometrage: " + car.Kilometrage.ToString() + ", Color: " + car.Color.ToString() + ", Firm: " + car.Firm.ToString());
        }
        else
        {
            Console.WriteLine("List doesn't contain car");
        }
    }
    public void PrintCarOfType(string type)
    {
        int i = 1;
        switch (type)
        {
            case "Gas":
                foreach (Car car in cars)
                {
                    if (ReferenceEquals(car.GetType(), typeof(GasCar)))
                    {
                        Console.WriteLine("Car number: " + i + " ");
                    }
                    i++;
                }
                break;
            case "Electric":
                foreach (Car car in cars)
                {
                    if (ReferenceEquals(car.GetType(), typeof(ElectricCar)))
                    {
                        Console.WriteLine("Car number: " + i + " ");
                    }
                    i++;
                }
                break;
            case "Hybrid":
                foreach (Car car in cars)
                {
                    if (ReferenceEquals(car.GetType(), typeof(HybridCar)))
                    {
                        Console.WriteLine("Car number: " + i + " ");
                    }
                    i++;
                }
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
                Console.WriteLine("Car number: " + i + " ");
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
                Console.WriteLine("Car number: " + i + " ");
            }
            i++;
        }
    }
}
