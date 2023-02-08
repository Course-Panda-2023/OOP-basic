using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class HybridCar : Car
{
    private string engine;
    public HybridCar(double price, int manifacturingYear, int kms, string color, string firm) : base(price, manifacturingYear, kms, color, firm)
    {
        this.engine = "Hybrid";
    }
}