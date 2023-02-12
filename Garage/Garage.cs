using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage
{ 
    class Garage
    {
         
        private List<Vehicle> _vehicles = new List<Vehicle>(); 
        public void AddVehicle(Vehicle vehicle)
        {
            _vehicles.Add(vehicle); 
        } 
        
        public void PrintVehicles()
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                Console.WriteLine(vehicle.ToString()); 
            } 
        }        
        public void PrintVehicleByType(string type)
        {
            
            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle.GetType().Name == type)
                {
                    Console.WriteLine(vehicle.ToString()); 
                } 
            } 
        
        }
        public void PrintVehiclesByColor(string color)
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle.Color == color)
                {
                    Console.WriteLine(vehicle.ToString());
                }
            }
        }
       
        public void PrintVehiclesAfterYear(int year)
        {
            foreach (Vehicle vehicle in _vehicles)
            {
                if (vehicle.Year >= year)
                {
                    Console.WriteLine(vehicle.ToString());
                } 
            } 
        }              
    }
}
