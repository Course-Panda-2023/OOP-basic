using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    internal class HybridCar : Cars.Car, IGasCar, IElectricCar
    {
        private string _battaryType;
        private int _batarryCapacity;
        private int _percentChargeLeft;
        private string _gasType;
        private int _gasTankCapacity;
        private int _currentGasAmount;

        public HybridCar(int price, int yearOfMake, int km, string color, string manifactur) : base(price, yearOfMake, km, color, manifactur)
        {
        }

        string IGasCar.GasType { get => _gasType; set => _gasType = value; }
        int IGasCar.GasTankCapacity { get => _gasTankCapacity; set => _gasTankCapacity = value; }
        int IGasCar.CurrentGasAmount { get => _currentGasAmount; set => _currentGasAmount = value; }
        string IElectricCar.BattaryType { get => _battaryType; set => _battaryType = value; }
        int IElectricCar.BatarryCapacity { get => _batarryCapacity; set => _batarryCapacity = value; }
        int IElectricCar.PercentChargeLeft { get => _percentChargeLeft; set => _percentChargeLeft = value; }

        void IElectricCar.Charge()
        {
            _percentChargeLeft = 100;
        }

        void IGasCar.FillGas()
        {
            _gasTankCapacity = _currentGasAmount;
        }
    }
}
