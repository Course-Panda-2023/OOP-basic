using System;

public class GarageMain
{
    public static void Main(string[] args)
    {
        ParkingLot parkingLot = new ParkingLot();
        
        // adding cars
        parkingLot.AddCar(CarType.Gas, 34000, 2012, 120000, "yellow", "Mazda");        
        parkingLot.AddCar(CarType.Gas, 44000, 2020, 10000, "black", "Suzuki");        
        parkingLot.AddCar(CarType.Electric, 76000, 2014, 120000, "blue", "Tesla");
        parkingLot.AddCar(CarType.Electric, 86000, 2011, 120000, "white", "Tesla");
        parkingLot.AddCar(CarType.Hybrid, 34000, 2000, 220000, "blue", "Toyota");
        
        // print cars details
        parkingLot.PrintCarsDetails();
        
        // removing cars
        parkingLot.RemoveCar(new ElectricCar(86000, 2011, 120000, "white", "Tesla")); // Car in lot
        parkingLot.RemoveCar(new ElectricCar(10000, 2021, 333300, "green", "Renault")); // Car NOT in lot
        parkingLot.PrintCarsDetails();
        
        
        // returning all gas-type cars
        parkingLot.GetCarsOfType(CarType.Gas);
        
        // returning all blue colored cars
        parkingLot.GetCarsOfColor("blue");

        // returning all cars after the year 2010        
        parkingLot.GetCarsAfterYear(2010);

    }
}
