using Garage;
using System.Drawing;

static string GetRandomString(int length)
{
    Random random = new Random();
    const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    return new string(Enumerable.Repeat(chars, length).Select(s => s[random.Next(s.Length)]).ToArray());
}

static Color GetRandomColor()
{
    Random random = new Random();
    int red = random.Next(256);     // Generates a random integer between 0 and 255
    int green = random.Next(256);   // Generates a random integer between 0 and 255
    int blue = random.Next(256);    // Generates a random integer between 0 and 255
    Color randomColor = Color.FromArgb(red, green, blue);
    return randomColor;
}

int numberOfCarsTypes = 3;
int range = 1001;
Car[] cars = new Car[range];
Random rand = new Random();

foreach (int i in Enumerable.Range(0, range))
{
    if (i % numberOfCarsTypes == 0)
    {
        cars[i] = new ElectronicCar(rand.NextDouble() * 10000, (uint) rand.Next(2006, 2023), (uint) rand.Next(90000, 400000), GetRandomColor(), GetRandomString(19));
    }
    else if (i % numberOfCarsTypes == 1)
    {
        cars[i] = new GasCar(rand.NextDouble() * 10000, (uint)rand.Next(2006, 2023), (uint)rand.Next(90000, 400000), GetRandomColor(), GetRandomString(19));
    }
    else if (i % numberOfCarsTypes == 2)
    {
        cars[i] = new HybridCar(rand.NextDouble() * 10000, (uint)rand.Next(2006, 2023), (uint)rand.Next(90000, 400000), GetRandomColor(), GetRandomString(19));
    }
}


foreach(var car in cars.AsSpan())
{
    car.PrintCarDetails();
}

GarageModel garageModel = new GarageModel();

garageModel.AddCars(cars);

garageModel.AllCarsDetails();

var carsList = garageModel.Filter(CarType.Electric, null, 2008);

Console.ReadKey();