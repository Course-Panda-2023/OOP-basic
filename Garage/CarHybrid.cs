using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CarHybrid : Car
{
    public CarHybrid(double price, int year, int kilometer, string color, string firm) : base(price, year, kilometer, color, firm, EngineType.Hybrid)
    {
    }
}