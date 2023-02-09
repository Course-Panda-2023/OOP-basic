using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        ParkingLot pl = new ParkingLot();
        pl.AddCar(100, 2000, 100000, "blue", "kia", Constants.GAS_TYPE);
        pl.AddCar(new ElectricCar(200, 2023, 0, "pink", "BMV"));
        pl.AddCar(new GasCar(150, 2015, 10000, "white", "ford"));
        pl.AddCar(1000, 1997, 500000, "blue", "kia", Constants.HYBRID_TYPE);

        Console.WriteLine("Car no.1:");
        pl.PrintCarInfo(1);
        Console.WriteLine("Gas cars:");
        pl.PrintByType(Constants.GAS_TYPE);
        Console.WriteLine("Blue cars:");
        pl.PrintByColor("blue");
        Console.WriteLine("2000+ cars:");
        pl.PrintByYear(2000);
    }
}
