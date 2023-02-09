// See https://aka.ms/new-console-template for more information
using Bank.Controller;
using Bank.Model;
using Bank.View;
using Bank.Utils;

Constants constants = new();
Operation operation = new();

BankModel bankModel = new();

BankGUI bankCLI = new BankCLI(constants, operation);

SystemClass system = new(bankModel, bankCLI);

system.Invoke();

Console.ReadLine();
