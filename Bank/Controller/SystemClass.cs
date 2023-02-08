using Bank.Model;
using Bank.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Controller
{
    internal class SystemClass
    {
        private BankModel bankModel;

        private BankGUI bankGUI;

        public SystemClass(BankModel _bankModel, BankGUI _bankGUI)
        {
            bankModel = _bankModel;
            bankGUI = _bankGUI;
        }
    }
}
