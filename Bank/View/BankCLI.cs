using Bank.Utils;
using System.ComponentModel.DataAnnotations;

namespace Bank.View
{
    internal class BankCLI : BankGUI
    {
        private Constants constants;
        private Operation operation;

        public BankCLI(Constants constants, Operation operation)
        {
            this.constants = constants;
            this.operation = operation;
        }


        public void Date()
        {
            throw new NotImplementedException();
        }
        
        private void CommandPrompt(string additionString = "")
        {
            Console.Write($"bank-command propmt>{additionString} {constants.space}");
        }

        public char InputAnOperation()
        {
            CommandPrompt();
            char op;

            do
            {
                op = (char)Console.ReadKey().Key;
            } while (!operation.operationKeys.Contains(op));

            return op;
        }

        public string OpenNewAccount()
        {
            
            string result;

            do
            {
                Console.WriteLine("Enter your name");
                CommandPrompt();
                result = Console.ReadLine();
            } while (result is null);

            return result;
        }
        public void OperationsInstruction()
        {
            string space = constants.space;
            ReadOnlySpan<char> operations = operation.operationKeys.AsSpan();
            for (int i = 0; i < operations.Length; ++i)
            {
                Console.WriteLine($"\tPress {operations[i]} to {operation.operationText[operations[i]]}");
            }
        }

        public void Welcome()
        {
            Console.WriteLine("Welcome to Bank!");
            Console.WriteLine();
        }

        private double SafelyInputDecimal(string op = "")
        {

            double result = 0.0;
            string input;
            bool convertedSuccessfullyOrNotInputed = false;
            
            do
            {
                CommandPrompt(op);
                input = Console.ReadLine();
                if (input is null) continue;
                result = Convert.ToDouble(input);
                convertedSuccessfullyOrNotInputed = true;
            } while (!convertedSuccessfullyOrNotInputed);


            return result;
        }
        public double Deposit()
        {
            return SafelyInputDecimal("desposit>");
        }

        public double Withdraw()
        {
            return SafelyInputDecimal(">withdraw>");
        }

        public void CloseAccount(double balance)
        {
            Console.WriteLine($"{Math.Round(balance, 2)}");
            Console.WriteLine("Closed successfully");
        }
    }
}
