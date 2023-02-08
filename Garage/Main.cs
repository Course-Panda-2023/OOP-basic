using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        GasCar car = new GasCar(50, 50, "green", 2013, "firmmmm");
        ElectricCar car2 = new ElectricCar(50, 50, "green", 2013, "firmmmm");
        CarsParkingLot list = new CarsParkingLot();
        list.AddCar(car);
        list.AddCar(car2);
        list.PrintElectric();

    }
}
