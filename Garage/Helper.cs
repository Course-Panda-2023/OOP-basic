using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    internal class Helper
    {

        public static void printList(List<Car> list)
        {
            foreach (Car car in list)
            {
                car.print();
            }
        }
    }
}
