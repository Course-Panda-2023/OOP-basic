using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

abstract class Car
{
    protected double price;
    public double Price 
    {
        get { return price; }
        set { price = value; }
    }
    protected int manifacturingYear;
    public int ManifacturingYear
    {
        get { return manifacturingYear; }
        set { manifacturingYear = value; }
    }
    protected int kms;
    public int Kms
    {
        get { return kms; }
        set { kms = value; }
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
    protected string? engine;
    public string? Engine
    {
        get { return engine; }
        set { engine = value; }
    }

    public Car(double price, int manifacturingYear, int kms, string color, string firm)
    {
        this.price = price;
        this.manifacturingYear = manifacturingYear;
        this.kms = kms;
        this.color = color;
        this.firm = firm;
    }
}