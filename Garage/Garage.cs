public abstract class Car
{

    int cost;
    string color;
    string firm;
    int kilometer;
    int year;
    string type;
    public Car(int cost, string color, string firm, int kilometer, int year, string type)
    {
        this.cost = cost;
        this.color = color;
        this.firm = firm;
        this.kilometer = kilometer;
        this.year = year;
        this.type = type;
    }

    public int getCost()
    {
        return cost;
    }
    public string getColor()
    {
        return color;
    }

    public int getKilometer()
    {
        return kilometer;
    }

    public int getYear()
    {

        return year;
    }

    public string getFirm()
    {
        return firm;
    }
    public string getType()
    {
        return type;
    }
    public string ToString()
    {
        string data = $"cast: {this.cost} color: {this.color} km: {this.kilometer} " +
            $"year: {this.year} firm: {this.firm} type: {this.type}";
        return data;
    }
}

public class GasCar : Car
{
    public GasCar(int cost, string color, string firm, int kilometer, int year) :
        base(cost, color, firm, kilometer, year, "Gas")
    { }
}

public class ElectricCar : Car
{
    ElectricCar(int cost, string color, string firm, int kilometer, int year) :
        base(cost, color, firm, kilometer, year, "Electric")
    { }
}
public class HybridCar : Car
{
    HybridCar(int cost, string color, string firm, int kilometer, int year) :
        base(cost, color, firm, kilometer, year, "Hybrid")
    { }
}

public class CarLot
{
    List<Car> cars = new List<Car>();
    void addCar(Car car)
    {
        cars.Add(car);
    }
    void removeCar(Car car)
    {
        cars.Remove(car);
    }
    void getGasCars()
    {
        foreach (Car car in cars)
        {
            if (car.getType().Equals("Gas"))
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
    void getElectricCars()
    {
        foreach (Car car in cars)
        {
            if (car.getType().Equals("Electric"))
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
    void getHybridCars()
    {
        foreach (Car car in cars)
        {
            if (car.getType().Equals("Hybrid"))
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
    void getColorCars(string color)
    {
        foreach (Car car in cars)
        {
            if (car.getColor().Equals(color))
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
    void getCarsFromYear(int year)
    {
        foreach (Car car in cars)
        {
            if (car.getYear() > year)
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
