using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CarPark
{
    private List<Car> cars;
    public CarPark(List<Car> cars)
    { this.cars = cars; }
    public CarPark()
    { this.cars = new List<Car>(); }
    public List<Car> getCars() 
    { return this.cars; }
    public void addCar(Car car)
    { this.cars.Add(car); }
    public void removeCar(Car car)
    { 
        if (this.cars.Contains(car))
            this.cars.Remove(car); 
    }
    public List<Car> getElectricCars() 
    { 
        List<Car> list = new List<Car>();
        foreach (Car car in this.cars) 
        {
            if (car.Engine == EngineType.Electric)
                list.Add(car); 
        }
        return list;
    }
    public List<Car> getGasCars()
    {
        List<Car> list = new List<Car>();
        foreach (Car car in this.cars)
        {
            if (car.Engine == EngineType.Gas)
                list.Add(car);
        }
        return list;
    }
    public List<Car> getHybridCars()
    {
        List<Car> list = new List<Car>();
        foreach (Car car in this.cars)
        {
            if (car.Engine == EngineType.Hybrid)
                list.Add(car);
        }
        return list;
    }
    public void printCarsDetails()
    {
        int i = 1;
        foreach (Car car in cars)
        {
            Console.WriteLine("Car " + i + " :");
            Console.WriteLine("Car Price: " + car.Price);
            Console.WriteLine("Car Year: " + car.Year);
            Console.WriteLine("Car Kilometer: " + car.Kilometer);
            Console.WriteLine("Car Color: " + car.Color);
            Console.WriteLine("Car Firm: " + car.Firm);
            Console.WriteLine("Car Engine: " + car.Engine);
            Console.WriteLine("-----------------");
            i++;
        }
    }
    public List<Car> getCarsByColor(string color)
    {
        List<Car> list = new List<Car>();
        foreach (Car car in this.cars)
        {
            if (car.Color == color.ToLower())
                list.Add(car);
        }
        return list;
    }
    public List<Car> getCarsByYear(int year) 
    {
        List<Car> list = new List<Car>();
        foreach (Car car in this.cars)
        {
            if (car.Year >= year)
                list.Add(car);
        }
        return list;
    }
}