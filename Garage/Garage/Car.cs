using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    public abstract class Car
    {
        public int price { get; set; }
        public int productionYear { get; set; }
        public int kilometer { get; set; }
        public string colour { get; set; }
        public string brand { get; set; }

        public Car (int price, int productionYear, int kilometer, string colour, string brand)
        {
            this.price = price;
            this.productionYear = productionYear;
            this.kilometer = kilometer;
            this.colour = colour;
            this.brand = brand;
        } 

        public bool Equals (Car c)
        {
            if(c == null) 
                return false;
            return (price == c.price && productionYear == c.productionYear && kilometer == c.kilometer &&
                colour == c.colour && brand == c.brand);
        }
    }
}
