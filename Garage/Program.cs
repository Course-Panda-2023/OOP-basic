// See https://aka.ms/new-console-template for more information
using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Test your class here
        */
        Garage.Garage garage = new Garage.Garage();
        garage.AddVehicle(new Garage.HybridVehicle(10000, 2010, 100000, "Red", "Volvo"));
        garage.AddVehicle(new Garage.GasVehicle(1000, 1990, 3000000, "Green", "Toyota"));
        garage.AddVehicle(new Garage.ElectricVehicle(20000, 2020, 200000, "Blue", "Hyunday"));
        garage.PrintVehicles();        
        garage.PrintVehicleByType("ElectricVehicle");
        garage.PrintVehiclesByColor("Blue");
        garage.PrintVehiclesAfterYear(2020);
    }
}
