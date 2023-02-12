public enum CarType
{
    Gas,
    Electric,
    Hybrid
}

public abstract class Car
{
    public CarType type {get;}
    public double price {get; set;}
    public int year {get;}
    public int km {get; set;}
    public string? color {get;}
    public string? firm {get;}
    public Car(CarType type, double price, int year, int km, string? color, string? firm)
    {
        this.type = type;
        this.price = price;
        this.year = year;
        this.km = km;
        this.color = color;
        this.firm = firm;
    }
    
    public bool IsSameCar(Car car)
    {
        return car.type == this.type && car.price == this.price && car.year == this.year &&
                            car.km == this.km && car.color == this.color && car.firm == this.firm;
    }

    public void CarDetails()
    {
        Console.WriteLine($"Car type is {this.type}");
        Console.WriteLine($"Car's price is {this.price}");
        Console.WriteLine($"Car's year is {this.year}");
        Console.WriteLine($"Car's km is {this.km}");
        Console.WriteLine($"Car's color is {this.color}");
        Console.WriteLine($"Car's firm is {this.firm}");
        Console.WriteLine("");
        
    }
}