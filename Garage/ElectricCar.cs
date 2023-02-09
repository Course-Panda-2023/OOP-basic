namespace ClassLibrary1.CarGarage;

public class ElectricCar: Car
{
    public ElectricCar(double price, int productionYear, int kilometer, string color, string firm):
        base(price, productionYear, kilometer, color, firm, CarType.Electric)
    {
        
    }
}