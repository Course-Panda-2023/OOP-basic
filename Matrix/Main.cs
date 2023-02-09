using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        double[,] mat1 = new double[,] { { 5, 2 }, { 5, 8 } };
        double[,] mat2 = new double[,] { { 2, 5 }, { 5, 8 } };
        Matrix mat3 = new Matrix(mat2);
        Matrix mat4 = new Matrix(mat1);
        Console.WriteLine(mat3.SumColumn(1));
        Console.WriteLine(mat3.CompareSums(mat4));
    }
}
