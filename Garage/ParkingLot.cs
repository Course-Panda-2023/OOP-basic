class ParkingLot
{
    public List<Car> cars = new List<Car>();

    public ParkingLot(){}

    public void AddCar(CarType type, double price, int year, int km, string? color, string? firm)
    {
        switch (type)
        {
            case CarType.Gas:
                this.cars.Add(new GasCar(price, year, km, color, firm));
                break;
            case CarType.Electric:
                this.cars.Add(new ElectricCar(price, year, km, color, firm));
                break;
            case CarType.Hybrid:
                this.cars.Add(new HybridCar(price, year, km, color, firm));
                break;
            default:
                Console.WriteLine("Shouldn't get here, type must much.");
                break;
        }
    }

    public void PrintCarsDetails()
    {
        Console.WriteLine("Printing cars details.");
        foreach (Car car in this.cars)
            car.CarDetails();
    }

    public void RemoveCar(Car rcar)
    {
        int removeIndex = -1;
        int i = 0;
        foreach (Car car in this.cars)
        {
            if (car.IsSameCar(rcar))
                {
                removeIndex = i;
                break;
                }
            i++;
        }
        if (removeIndex == -1)
            Console.WriteLine("Car not in parking lot.");
        else
            this.cars.RemoveAt(removeIndex);
    }

    public List<Car> GetCarsOfType(CarType type)
    {   
        Console.WriteLine($"Fetching cars of type '{type}'");
        List<Car> carsOfType = new List<Car>();
        foreach (Car car in this.cars)
        {
            if (car.type == type)
            {
                carsOfType.Add(car);
                car.CarDetails();
            }
        }
        return carsOfType;
    }
    public List<Car> GetCarsOfColor(string color)
    {
        Console.WriteLine($"Fetching cars of color '{color}'");
        List<Car> carsOfColor = new List<Car>();
        foreach (Car car in this.cars)
        {
                if (car.color == color)
                {
                    carsOfColor.Add(car);
                    car.CarDetails();
                }
        }
        return carsOfColor;
    }
    public List<Car> GetCarsAfterYear(int year)
    {
        Console.WriteLine($"Fetching cars after the year {year}");
        List<Car> carsAfterYear = new List<Car>();
        foreach (Car car in this.cars)
        {
                if (car.year >= year)
                {
                    carsAfterYear.Add(car);
                    car.CarDetails();
                }
        }
        return carsAfterYear;
    }
}