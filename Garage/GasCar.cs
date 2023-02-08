using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class GasCar : Car
{
    private string engine;
    public GasCar(double price, int manifacturingYear, int kms, string color, string firm) : base(price, manifacturingYear, kms, color, firm)
    {
        this.engine = "Gas";
    }
}