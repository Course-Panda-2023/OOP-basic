using System;

abstract class Car
{
    public double Price { get; set; }

    public int YearOfProduction { get; set; }
    public int Kilometrajh { get; set; }

    public string Color { get; set; }
    public string Brand { get; set; }
    public Car(double Price, int YearOfProduction, int Kilometrajh, string Color, string Brand)
    {
        this.Price = Price;
        this.YearOfProduction = YearOfProduction;
        this.Kilometrajh = Kilometrajh;
        this.Color = Color;
        this.Brand = Brand;
    }

    public virtual void getCarDetails()
    {
        Console.WriteLine("default car");
    }
}
class GasCar : Car
{
    public GasCar(double price, int yearOfProduction, int kilometrajh, string color, string brand) : base(price, yearOfProduction, kilometrajh, color, brand)
    {

    }
    public override void getCarDetails()
    {
        Console.WriteLine($"car type: gas, car price: {Price}, kilometrajh: {Kilometrajh}, yearofproduction: {YearOfProduction}, color: {Color}, brand: {Brand}");
    }
}

class ElectricCar : Car
{
    public ElectricCar(double price, int yearOfProduction, int kilometrajh, string color, string brand) : base(price, yearOfProduction, kilometrajh, color, brand)
    {

    }
    public override void getCarDetails()
    {
        Console.WriteLine($"car type: eletric, car price: {Price}, kilometrajh: {Kilometrajh}, yearofproduction: {YearOfProduction}, color: {Color}, brand: {Brand}");
    }
}

class HybridCar : Car
{
    public HybridCar(double price, int yearOfProduction, int kilometrajh, string color, string brand) : base(price, yearOfProduction, kilometrajh, color, brand)
    {

    }
    public override void getCarDetails()
    {
        Console.WriteLine($"car type: hybrid, car price: {Price}, kilometrajh: {Kilometrajh}, yearofproduction: {YearOfProduction}, color: {Color}, brand: {Brand}");
    }
}

class carGarage
{
    public List<Car> cars;

    public carGarage()
    {
        cars = new List<Car>();
    }

    public carGarage(List<Car> cars)
    {
        this.cars = cars;
    }

    public void addCarToList(Car car)
    {
        cars.Add(car);
    }

    public void removeCar(Car car)
    {
        cars.Remove(car);
    }

    public void printAllCars()
    {
        foreach (Car car in cars)
        {
            car.getCarDetails();
        }
    }

    public void getCarsByType(string type)
    {
        switch (type)
        {
            case "gas":
                foreach (Car c in cars)
                {
                    if (ReferenceEquals(c.GetType(), typeof(GasCar)))
                    {
                        c.getCarDetails();
                    }
                }
                break;
            case "electric":
                foreach (Car c in cars)
                {
                    if (ReferenceEquals(c.GetType(), typeof(ElectricCar)))
                    {
                        c.getCarDetails();
                    }
                }
                break;
            case "hybrid":
                foreach (Car c in cars)
                {
                    if (ReferenceEquals(c.GetType(), typeof(HybridCar)))
                    {
                        c.getCarDetails();
                    }
                }
                break;
            default:
                Console.WriteLine("invalid");
                break;
        }
    }

    public void getCarsByColor(string color)
    {
        foreach (Car car in cars)
        {
            if (car.Color == color)
            {
                car.getCarDetails();
            }
        }
    }

    public void getCarsBeforeYear(int year)
    {
        foreach (Car car in cars)
        {
            if (car.YearOfProduction < year)
            {
                car.getCarDetails();
            }
        }
    }
}

class Program
{
    private static void Main(string[] args)
    {
        carGarage garage = new carGarage();
        GasCar c1 = new GasCar(400, 2018, 400, "blue", "toyota");
        ElectricCar c2 = new ElectricCar(300, 2020, 400, "green", "mazda");
        ElectricCar c3 = new ElectricCar(1000, 2019, 900, "white", "ferrari");
        garage.addCarToList(c1);
        garage.addCarToList(c2);
        garage.addCarToList(c3);
        Console.WriteLine("get all electric cars: ");
        garage.getCarsByType("electric");
        Console.WriteLine("get green cars");
        garage.getCarsByColor("green");
        Console.WriteLine("get all cars before the year 2020");
        garage.getCarsBeforeYear(2020);
        Console.WriteLine("get all cars:");
        garage.printAllCars();
    }
}


