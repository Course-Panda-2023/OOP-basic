using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class ElectricCar : Car
{
    private string engine;
    public ElectricCar(double price, int manifacturingYear, int kms, string color, string firm) : base(price, manifacturingYear, kms, color, firm)
    {
        this.engine = "Electric";
    }
}