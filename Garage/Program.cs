// See https://aka.ms/new-console-template for more information
using CarGarage;
using static CarGarage.Helper;

Console.WriteLine("Hello, World!");


MyCarGarage myCarG =new MyCarGarage();
Car car1 = new GasCar(1000.0,2003,99.6,"blue","g");
Car car2 = new ElectricCar(406.3, 2020, 55.6, "green", "d");
Car car3 = new HybridCar(265.3, 2010, 23.4, "blue", "f");
Car car4 = new GasCar(6521.4, 2012, 11.2, "black", "u");

myCarG.addCar(car1);    
myCarG.addCar(car2);    
myCarG.addCar(car3);    
myCarG.addCar(car4);

//Helper.printList(myCarG.allCars());
//Helper.printList(myCarG.getCarsByEngine("ElectricCar"));
//Helper.printList(myCarG.getCarsByYear(2010));
//Helper.printList(myCarG.getCarsByColor("blue"));





