using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double[,] mat2 = new double[,] { { 2, 5 }, { 5, 8 } };
        Matrix mat = new Matrix(mat2, 2, 2);
        Console.WriteLine(mat.SumColumn(1));
    }
}
