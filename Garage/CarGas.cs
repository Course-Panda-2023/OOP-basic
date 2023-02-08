using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CarGas : Car
{
    public CarGas(double price, int year, int kilometer, string color, string firm) : base(price, year, kilometer, color, firm, EngineType.Gas)
    {
    }
}