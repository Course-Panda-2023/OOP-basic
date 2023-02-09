using System;
using System.Collections.Generic;

abstract class Car
{
    private double mPrice;
    public double Price
    {
        get { return mPrice; }
        set { mPrice = value; }
    }
    private int mYear;
    public int Year
    {
        get { return mYear; }
        set { mYear = value; }
    }
    private double mKilometer;
    public double Kilometer
    {
        get { return mKilometer; }
        set { mKilometer = value; }
    }
    private string mColor;
    public string Color
    {
        get { return mColor; }
        set { mColor = value; }
    }
    private string mFirm;
    public string Firm
    {
        get { return mFirm; }
        set { mFirm = value; }
    }


    public Car(double price, double kilometer, string color, int year, string firm)
    {
        this.mPrice = price;
        this.mKilometer = kilometer;
        this.mColor = color;
        this.mYear = year;
        this.mFirm = firm;
    }
}

