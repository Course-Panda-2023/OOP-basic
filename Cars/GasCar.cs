using Cars;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CarGarage
{
    public class GasCar : Car, IGasCar
    {
        public GasCar(int price, int yearOfMake, int km, string color, string manifactur) : base(price, yearOfMake, km, color, manifactur)
        {
        }

        private string _gasType;
        private int _gasTankCapacity;
        private int _currentGasAmount;
        string IGasCar.GasType { get => _gasType; set => _gasType = value; }
        int IGasCar.GasTankCapacity { get => _gasTankCapacity; set => _gasTankCapacity = value; }
        int IGasCar.CurrentGasAmount { get => _currentGasAmount; set => _currentGasAmount = value; }

        void IGasCar.FillGas()
        {
           _gasTankCapacity = _currentGasAmount;
        }
    }
    }
}
