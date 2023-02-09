using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarGarage
{
    public interface IGasCar
    {
        protected string GasType { get; set; }
        protected int GasTankCapacity { get; set; };
        protected int CurrentGasAmount { get; set; };
        protected void FillGas();
    }
}
