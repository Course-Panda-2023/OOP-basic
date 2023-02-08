using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Car
{
    /// <summary>
    /// double price
    /// int year
    /// int kilometer
    /// string color 
    /// string firm
    /// </summary>
    protected double price;
    public double Price
    {
        get { return price; }
        set { price = value; }
    }
    protected int year;
    public int Year
    {
        get { return year; }
        set { year = value; }
    }
    protected int kilometer;
    public int Kilometer
    {
        get { return kilometer; }
        set { kilometer = value; }
    }
    protected string? color;
    public string? Color
    {
        get { return color; }
        set { color = value; }
    }
    protected string? firm;
    public string? Firm
    {
        get { return firm; }
        set { firm = value; }
    }
    protected EngineType? engine;
    public EngineType? Engine
    {
        get { return engine; }
        set { engine = value; }
    }
    public Car(double price, int year, int kilometer, string color, string firm, EngineType engine)
    {
        this.price = price;
        this.year = year;
        this.kilometer = kilometer;
        this.color = color.ToLower();
        this.firm = firm;
        this.engine = engine;
    }
}