using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Test your class here
        */
        int cost, string color, string firm, int kilometer, int year
        GasCar car = new GasCar(120, "red", "Mazda", 159000, 2006);
        GasCar car1 =  new GasCar(12000, "green", "Mercedes", 19000, 2016);
        GasCar car2 = new GasCar(30000, "green", "ford", 19000, 2016);
        ElectricCar car3 = new ElectricCar(1200, "blue", "Mazda", 13700, 2015);
        ElectricCar car4 =  new GasCar(120050, "red", "Mercedes", 159000, 2019);
        ElectricCar car5 = new GasCar(30000, "green", "ford", 19000, 2016);
        HybridCar car6 = new HybridCar(1000, "blue", "Mazda", 12000, 2011); 
        HybridCar car7 = ; new GasCar(12340, "green", "Mercedes", 159000, 2008);
        HybridCar car8= new GasCar(300000, "red", "ford", 19000, 2023);
        CarLot carlot = new CarLot();
        carlot.addCar(car);
        carlot.addCar(car1);
        carlot.addCar(car2);
        carlot.addCar(car3);
        carlot.addCar(car4);
        carlot.addCar(car5);
        carlot.addCar(car6);
        carlot.addCar(car7);
        carlot.addCar(car8);
        carlot.getGasCars();
        carlot.getElectricCars();
        carlot.getHybridCars();
        carlot.getColorCars("red");
        carlot.getCarsFromYear(2015);
        carlot.removeCar(car);
        carlot.removeCar(car1);
        carlot.removeCar(car2);
        carlot.removeCar(car3);
        carlot.getColorCars("blue");
        carlot.removeCar(car4);
        carlot.removeCar(car5);
        carlot.removeCar(car6);
        carlot.getColorCars("green");
        carlot.removeCar(car7);
        carlot.removeCar(car8);



    }
}
