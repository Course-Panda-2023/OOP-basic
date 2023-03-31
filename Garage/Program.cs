// See https://aka.ms/new-console-template for more information
using System;
namespace Garage_project
{
    public class HelloWorld
    {
        public static void Main(string[] args)
        {
            
            Car carA = new GasEngineCar(20000,2003,200,EColor.Black,Efirm.Mercedes);
            ElectricCar carB = new ElectricCar(30000, 2000, 200, EColor.Black, Efirm.Tesla);
            Car carC= new HybridCar(10000, 1999, 200, EColor.Blue, Efirm.Mercedes);

            /*carA.PrintCarInfo();
            carB.PrintCarInfo();
            carC.PrintCarInfo();*/

            Garage g = new Garage();
            g.AddCar(carA);
            g.AddCar(carB);
            g.AddCar(carC);

            //g.GetCarsByYear(2004);
            //g.GetCarsByType(typeof(ElectricCar));
            g.GetCarsByColor(EColor.Black);
        }
    }
}