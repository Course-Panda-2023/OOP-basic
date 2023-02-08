using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ParkingLot
{
    private List<Car> cars;
    public List<Car> Cars
    {
        get { return cars; }
        set { cars = value; }
    }
    public ParkingLot()
    {
        cars = new List<Car>();
    }
    public ParkingLot(List<Car> cars)
    {
        this.cars = cars;
    }
    public List<Car> GetGasCars()
    {
        List<Car> list = new List<Car>();
        foreach (Car car in cars)
        {
            if (car.Engine == "Gas")
                list.Add(car);
        }
        return list;
    }
    public List<Car> GetElectricCars()
    {
        List<Car> list = new List<Car>();
        foreach (Car car in cars)
        {
            if (car.Engine == "Electric")
                list.Add(car);
        }
        return list;
    }
    public List<Car> GetHybridCars()
    {
        List<Car> list = new List<Car>();
        foreach (Car car in cars)
        {
            if (car.Engine == "Hybrid")
                list.Add(car);
        }
        return list;
    }
    public List<Car> GetColorCars(string color)
    {
        List<Car> list = new List<Car>();
        foreach (Car car in cars)
        {
            if (car.Color == color)
                list.Add(car);
        }
        return list;
    }
    public List<Car> GetCarsYear(int year)
    {
        List<Car> list = new List<Car>();
        foreach (Car car in cars)
        {
            if (car.ManifacturingYear > year)
                list.Add(car);
        }
        return list;
    }
}