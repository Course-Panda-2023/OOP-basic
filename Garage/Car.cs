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
    private int kilometer;
    public int Kilometer
    {
        get { return kilometer; }
        set { kilometer = value; }
    }
    private string? color;
    public string? Color { 
        get { return color; }
        set { color = value; }
    }
    private string? firm;
    public string? Firm
    { 
        get { return firm; }
        set { firm = value; }
    }
    private EngineType? engine;
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