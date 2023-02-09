namespace OOP.CarGarage;

public class Test
{
    public static void Main(string[] args)
    {
        Car[] cars = new Car[]
        {
            new GasCar(35000, 2013, 91000, "brown", "must + third-side"),
            new ElectricCar(100000, 2016, 3000, "yellow", "must + third-side"),
            new HybridCar(30000, 2023, 0, "blue", "must"),
            new GasCar(100000, 2020, 4000, "yellow", "third-side"),
            new ElectricCar(350000, 2023, 1000, "black", "must + third-side"),
            new HybridCar(3000, 2000, 410000, "gray", "must + third-side")
        };

        CarGarage g = new CarGarage(cars);
        
        g.GetByType(CarType.Gas);
        Console.WriteLine("---------------");
        g.GetByType(CarType.Electric);
        Console.WriteLine("---------------");
        g.GetByType(CarType.Hybrid);
        Console.WriteLine("---------------");
        
        g.GetByColor("yellow");
        Console.WriteLine("---------------");
        g.GetByColor("black");
        
        Console.WriteLine("---------------");
        g.GetByProductionYear(2016);
        Console.WriteLine("---------------");
        g.GetByProductionYear(2019);
    }
}