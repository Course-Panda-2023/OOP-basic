// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");
Matrix a = new Matrix(3, 3);

Matrix b = new Matrix(3, 3);




System.Random random = new System.Random();
for (int i = 0; i < a.GetLength(0); i++)
{
    for (int j = 0; j < a.GetLength(1); j++)
    {
        {
            a[i, j] = random.Next(0, 10);
            b[i, j] = random.Next(0, 10);
        }
    }
}


static void WriteMatrix(Matrix a) 
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($"{a[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}
Matrix c = a + b;
Matrix d = c;
WriteMatrix(a); 
WriteMatrix(b);
WriteMatrix(c);
Console.WriteLine(a.SumRow(0));
Console.WriteLine(a.SumColumn(0));
Console.WriteLine(a.CompareSums(b));
Console.WriteLine(c.CompareSums(d));