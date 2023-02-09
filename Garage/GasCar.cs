namespace ClassLibrary1.CarGarage;

public class GasCar: Car
{
    public GasCar(double price, int productionYear, int kilometer, string color, string firm):
        base(price, productionYear, kilometer, color, firm, CarType.Gas)
    {
        
    }
}