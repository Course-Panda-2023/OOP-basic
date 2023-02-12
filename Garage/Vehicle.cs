namespace Garage
{
    abstract class Vehicle
    {
        
        private double _price;
        private int _year;
        private int _mileage;
        private string _color;        
        private string _brand;
        public Vehicle(double price, int year, int mileage, string color, string brand)
        {
            _price = price;
            _year = year;
            _mileage = mileage;
            _color = color;
            _brand = brand;
        }

        public double Price
        {
            get
            {
                return _price;
            }
        }
        public int Year
        {
            get
            {
                return _year;
            }
        }
        public int Mileage
        {
            get
            {
                return _mileage;
            }
        }
        public string Color
        {
            get
            {
                return _color;
            }
        }
        
       
        public string Brand
        {
            get
            {
                return _brand;
            }
        }

        public virtual string ToString()
        {         
        
            return $"Price: {_price}, Year: {_year}, Mileage: {_mileage}, Color: {_color}, Brand: {_brand}";
        
        }

    }
}
