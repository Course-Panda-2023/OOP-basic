namespace ClassLibrary1.CarGarage;

public class CarGarage
{
    private Car[] _cars;
    
    public CarGarage(Car[] cars)
    {
        _cars = cars;
    }
    
    private delegate bool ChoiceCondition(Car car);

    private void GetByCondition(ChoiceCondition condition)
    {
        Car[] cars = this._cars.Where(c => condition(c)).ToArray();
        foreach (Car car in cars)
        {
            car.PrintDetails();
        }
    }

    public void GetByType(CarType type)
    {
        this.GetByCondition(c => c.Type == type);
    }

    public void GetByColor(string color)
    {
        this.GetByCondition(c => c.Color == color);
    }

    public void GetByProductionYear(int year)
    {
        this.GetByCondition(c => c.ProductionYear >= year);
    }
}