using Investment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvestmentBank
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.OpenBank();
        }
    }
}