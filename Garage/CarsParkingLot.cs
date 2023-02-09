using System;
using System.Collections.Generic;

class CarsParkingLot
{
    private List<Car> mCarList;

    public CarsParkingLot(List<Car> carList)
    {
        this.mCarList = carList;
    }
    public CarsParkingLot()
    {
        mCarList = new List<Car>();
    }
    public void GetCarInfo(Car car)
    {
        if (mCarList.Count != 0 && mCarList.Contains(car))
        {
            Console.WriteLine($"price: {car.Price}, year: {car.Year}, kilometer: {car.Kilometer}, color: {car.Color}, firm: {car.Firm} ");
        }
    }
    public void PrintType(Type car)
    {
        for (int i = 0; i < mCarList.Count; i++)
        {
            if (Object.ReferenceEquals(mCarList[i].GetType(), car))
            {
                Console.WriteLine(i);
            }
        }
    }
    public void PrintByColor(string color)
    {
        for (int i = 0; i < mCarList.Count; i++)
        {
            if (mCarList[i].Color == color)
            {
                Console.WriteLine(i);
            }
        }
    }

    public void PrintByYear(int year)
    {
        for (int i = 0; i < mCarList.Count; i++)
        {
            if (mCarList[i].Year >= year)
            {
                Console.WriteLine(i);
            }
        }
    }

    public void AddCar(Car car)
    {
        mCarList.Add(car);
    }
    public void RemoveCar(Car car)
    {
        mCarList.Remove(car);
    }



}
