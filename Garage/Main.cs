using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        GasCar car = new GasCar(50, 50, "green", 2013, "firmmmm");
        ElectricCar car2 = new ElectricCar(50, 50, "pink", 2002, "firmmmm");
        ElectricCar car3 = new ElectricCar(500, 50, "yellow", 2021, "firmmmm");
        CarsParkingLot list = new CarsParkingLot();
        list.AddCar(car);
        list.AddCar(car2);
        list.AddCar(car3);
        list.PrintType(typeof(GasCar));
        list.GetCarInfo(car);
        list.PrintByYear(2005);

    }
}
