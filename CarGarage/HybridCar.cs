namespace OOP.CarGarage;


public class HybridCar: Car
{
    public HybridCar(double price, int productionYear, int kilometer, string color, string firm):
        base(price, productionYear, kilometer, color, firm, CarType.Hybrid)
    {
    
    }
}

