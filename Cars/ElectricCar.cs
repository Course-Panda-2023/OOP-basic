using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    public class ElectricCar : IElectricCar
    {
        private string _battaryType;
        private int _batarryCapacity;
        private int _percentChargeLeft;
        string IElectricCar.BattaryType { get => _battaryType; set => _battaryType = value; }
        int IElectricCar.BatarryCapacity { get => _batarryCapacity; set => _batarryCapacity = value; }
        int IElectricCar.PercentChargeLeft { get => _percentChargeLeft; set => _percentChargeLeft = value; }

        void IElectricCar.Charge()
        {
            _percentChargeLeft = 100;
        }
    }
}
