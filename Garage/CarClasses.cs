using System;
using System.Collections.Generic;

abstract class Car
{
    private double mPrice;
    public double Price { get; set; }
    private int mYear;
    public int Year { get; set; }
    private int mKilometrage;
    public int Kilometrage { get; set; }
    private string mColor;
    public string Color { get; set; }
    private string mFirm;
    public string Firm { get; set; }

    public Car(double price, int year, int kilometrage, string color, string firm)
    {
        this.mPrice = price;
        this.mYear = year;
        this.mKilometrage = kilometrage;
        this.mColor = color;
        this.mFirm = firm;
    }
}
