namespace OOP.CarGarage;

public abstract class Car
{
    internal readonly double Price;
    internal readonly int ProductionYear;
    internal readonly int Kilometer;
    internal readonly string Color;
    internal readonly string Firm;
    internal readonly CarType Type;

    // constructor is protected cause it won't be used outside of the inheriting classes
    // because we can't create instances of this class as it's an abstract one
    protected Car(double price, int productionYear, int kilometer, string color, string firm, CarType type)
    {
        Price = price;
        ProductionYear = productionYear;
        Kilometer = kilometer;
        Color = color;
        Firm = firm;
        Type = type;
    }

    public void PrintDetails()
    {
        Console.WriteLine(
            $"Price={Price}, " +
            $"Production Year={ProductionYear}, " +
            $"Kilometer={Kilometer}, " +
            $"Color={Color}, " +
            $"Firm={Firm}, " +
            $"Type={Enum.GetName(typeof(CarType), this.Type)}"
        );
    }
}