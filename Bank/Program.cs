// See https://aka.ms/new-console-template for more information
using Bank.Controller;
using Bank.Model;
using Bank.View;

BankModel bankModel = new();

BankGUI bankCLI = new BankCLI();

SystemClass System = new(bankModel, bankCLI);

Console.ReadLine();
