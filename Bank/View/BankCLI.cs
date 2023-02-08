using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.View
{
    internal class BankCLI : BankGUI
    {
        public void OpenNewAccount()
        {

        }
        public void OperationsInstruction()
        {
            Console.WriteLine("Press W - to withdraw\n" +
                "     D - to deposit account\n" +
                "     C - to close the account\n");
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to Bank!");
        }
    }
}
