using System;
using System.Collections.Generic;

abstract class Cars
{
    private double price;
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    private int year;
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    private double kilometer;
    public double Kilometer
    {
        get { return kilometer; }
        set { kilometer = value; }
    }
    private string color;
    public string Color
    {
        get { return color; }
        set { color = value; }
    }
    private string firm;
    public string Firm
    {
        get { return firm; }
        set { firm = value; }
    }


    public Cars(double price, double kilometer, string color, int year, string firm)
    {
        this.price = price;
        this.kilometer = kilometer;
        this.color = color;
        this.year = year;
        this.firm = firm;
    }
}

class GasCar : Cars
{
    public GasCar(double price, double kilometer, string color, int year, string firm) : base(price, kilometer, color, year, firm)
    {
    }

}
class ElectricCar : Cars
{
    public ElectricCar(double price, double kilometer, string color, int year, string firm) : base(price, kilometer, color, year, firm)
    {
    }

}
class Hybrid : Cars
{
    public Hybrid(double price, double kilometer, string color, int year, string firm) : base(price, kilometer, color, year, firm)
    {
    }

}
class CarsParkingLot
{
    private List<Cars> carList;

    public CarsParkingLot(List<Cars> carList)
    {
        this.carList = carList;
    }
    public CarsParkingLot()
    {
        carList = new List<Cars>();
    }
    public void GetCarInfo(Cars car)
    {
        if (carList.Count != 0 && carList.Contains(car))
        {
            Console.WriteLine($"price: {car.Price}, year: {car.Year}, kilometer: {car.Kilometer}, color: {car.Color}, firm: {car.Firm} ");
        }
    }

    public void PrintGas()
    {

        for (int i = 0; i < carList.Count; i++)
        {
            if (Object.ReferenceEquals(carList[i].GetType(), typeof(GasCar)))
            {
                Console.WriteLine(i);
            }
        }
    }
    public void PrintElectric()
    {

        for (int i = 0; i < carList.Count; i++)
        {
            if (Object.ReferenceEquals(carList[i].GetType(), typeof(ElectricCar)))
            {
                Console.WriteLine(i);
            }
        }
    }
    public void PrintHybrid()
    {

        for (int i = 0; i < carList.Count; i++)
        {
            if (Object.ReferenceEquals(carList[i].GetType(), typeof(Hybrid)))
            {
                Console.WriteLine(i);
            }
        }
    }

    public void PrintByColor(string color)
    {
        for (int i = 0; i < carList.Count; i++)
        {
            if (carList[i].Color == color)
            {
                Console.WriteLine(i);
            }
        }
    }

    public void PrintByYear(int year)
    {
        for (int i = 0; i < carList.Count; i++)
        {
            if (carList[i].Year >= year)
            {
                Console.WriteLine(i);
            }
        }
    }

    public void AddCar(Cars car)
    {
        carList.Add(car);
    }
    public void RemoveCar(Cars car)
    {
        carList.Remove(car);
    }



}