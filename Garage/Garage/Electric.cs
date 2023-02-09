using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public class Electric : Car
    {
        public Electric(int price, int productionYear, int kilometer, string colour, string brand) : base(price, productionYear, kilometer, colour, brand)
        {
        }
    }
}
