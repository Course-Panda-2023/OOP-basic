using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    class CarGarage
    {
        private List<Car> carList;

        public void garageMenu()
        {
            bool closeGarage = false;
            string input = "";
            while(closeGarage == false)
            {
                Console.WriteLine("Press the designated button to perform the corresponding operation:\n" +
                    "1 - Get car information by id\n" +
                    "2 - Get car list by car type\n" +
                    "3 - Get car list by color\n" +
                    "4 - Get cars produced after a certain year\n" +
                    "5 - get list of cars in garage");
                input = Console.ReadLine();
                switch (input)
                {
                    case '1':
                        Console.WriteLine("Enter car id:");
                        string idInput = Console.ReadLine();
                        Car c = getCar(idInput);
                        if (c == null)
                        {
                            Console.WriteLine("Invalid id");
                        }
                        else
                        {
                            c.printInfo();
                        }
                        break;
                    case '2':
                        Console.WriteLine("Enter car type:");
                        string carTypeInput = Console.ReadLine();
                        foreach(Car c in this.carList)
                        {
                            if (string.equels(c.printCarType(), carTypeInput))
                            {
                                c.printInfo();
                            }
                        }
                        break;
                    case '3':
                        Console.WriteLine("Enter car color:");
                        string carColorInput = Console.ReadLine();
                        foreach (Car c in this.carList)
                        {
                            if (string.equels(c.getColor(), carTypeInput))
                            {
                                c.printInfo();
                            }
                        }
                        break;
                    case '4':
                        Console.WriteLine("Enter year:");
                        string inputYearStr = Console.ReadLine();
                        int yearInput = 0;
                        try
                        {
                            yearInput = int.Parse(inputYearStr);
                            foreach (Car c in this.carList)
                            {
                                if (c.getYearOdProduction() >= yearInput)
                                {
                                    c.printInfo();
                                }
                            }

                        }
                        catch(Exception e) 
                        {
                            Console.WriteLine("Invalid year");
                        }
                        break;
                    case '5':
                        Console.WriteLine("The id of the cars is:");
                        foreach(CarGarage c in this.carList)
                        {
                            Console.WriteLine(c.getId());
                        }
                        break;
                }
            }
        }

        public Car getCar(string carId)
        {
            foreach (Car car in carList) 
            {
                if (string.equels(car.getId(), carId))
                {
                    return car;
                }
            }
            return null;
        }
        public CarGarage()
        {
            carList < Car > cList = new List();
            Car c1 = new ElectricCar("10", 1, 2000, 0, "blue", "ford");
            Car c2 = new ElectricCar("10", 1, 2000, 0, "blue", "ford");
            Car c3 = new ElectricCar("10", 1, 2000, 0, "blue", "ford");
            carList.Add(c1);
            carList.Add(c2);
            carList.Add(c3);
            this.carList = cList;
        }
    }
}