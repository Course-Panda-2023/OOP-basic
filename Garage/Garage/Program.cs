

namespace Garage
{
    class Program
    {
        public static void Main(string[] args)
        {
            Gas c1 = new Gas(100000, 2020, 1000, "white", "Toyota");
            Hybrid c2 = new Hybrid(60000, 2014, 100000, "black", "Audi");
            Electric c3 = new Electric(250000, 2023, 0, "white", "Skoda");
            Electric c4 = new Electric(170000, 2021, 15000, "blue", "Tesla");
            Gas c5 = new Gas(6000, 2008, 150000, "blue", "Skoda");
            Hybrid c6 = new Hybrid(120000, 2021, 80000, "black", "Toyota");
            Gas c7 = new Gas(90000, 2018, 60000, "blue", "Audi");
            Hybrid c8 = new Hybrid(100000, 2019, 90000, "white", "Toyota");

            Garage garage = new Garage();

            garage.PrintCarInfo(c3);
            Console.WriteLine();

            garage.AddCar(c1);
            garage.AddCar(c2);
            garage.AddCar(c3);
            garage.AddCar(c4);
            garage.AddCar(c5);
            garage.AddCar(c6);
            garage.AddCar(c7);
            garage.AddCar(c8);
            
            for (int i = 0; i < garage.Cars.Count; i++)
            {
                garage.PrintCarInfo(garage.Cars[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Removing c3");

            garage.RemoveCar(c3);

            for (int i = 0; i < garage.Cars.Count; i++)
            {
                garage.PrintCarInfo(garage.Cars[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Returning all electric cars");
            garage.PrintCarsByType("Electric");

            Console.WriteLine();
            Console.WriteLine("Returning all blue cars");
            garage.PrintCarsByColour("blue");

            Console.WriteLine();
            Console.WriteLine("Returning all cars produced after 2020");
            garage.PrintCarsByYear(2020);

        }
    }
}