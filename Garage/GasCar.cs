using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP-Basic
{
    public class GasCar: Car
    {
        public GasCar(double price, int year, int km, string color, string company) : base(price, year, km, color, company)
        {
            this.type = Constants.GAS_TYPE;
        }
    }
}
