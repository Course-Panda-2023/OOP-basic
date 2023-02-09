using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    public interface IElectricCar
    {
        protected string BattaryType { get; set; }
        protected int BatarryCapacity { get; set; };
        protected int PercentChargeLeft { get; set; }
        protected void Charge();
    }
}
