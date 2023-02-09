using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        GasCar car = new GasCar(100, 2003, 2000, "Red", "Ford");
        ElectricCar electCar = new ElectricCar(100, 2003, 2000, "Red", "Ford");
        ParkingLot lot = new ParkingLot();
        lot.AddCar(car);
        lot.PrintCarOfType("Gas");
        lot.AddCar(electCar);
        lot.PrintCarOfType("Electric");
    }
}
