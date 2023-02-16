using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{
    internal abstract class Car
    {
        protected CarType carType { get; set; }

        private double price;

		private uint yearOfMade;

		private uint kilometers;

		private Color color;

		private string firm = "";

		public Car(double price, uint yearOfMade, uint kilometers, Color color, string firm, CarType carType = CarType.None)
		{
			this.price = price;
			this.yearOfMade = yearOfMade;
			this.kilometers = kilometers;
			this.color = color;
			this.firm = firm;
		}
		public string Firm
        {
			get { return firm; }
			set { firm = value; }
		}

		public Color Color
        {
            get { return color; }
            set { color = value; }
        }

        public uint Kilometers
        {
            get { return kilometers; }
            set { kilometers = value; }
        }


        public uint YearOfMade
        {
			get { return yearOfMade; }
			set { yearOfMade = value; }
		}

		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		public CarType CarType { get { return carType; } }

		public abstract void PrintCarDetails();
    }
}
