using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Matrix m1 = new Matrix(8, 8);

        int[,] temp = { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 }, { 4, 4, 4 } };
        int[,] temp1 = { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };

        Matrix m2 = new Matrix(temp);
        Matrix m3 = new Matrix(temp1);
        Matrix m4;

        Console.WriteLine(m2.GetValueAt(4, 1));
        Console.WriteLine(m2.SumRow(2));
        Console.WriteLine(m2.SumColumn(2));

        Console.WriteLine(m2.CompareSums(m1));
        Console.WriteLine(m1.CompareSums(m1));

        m2.MultiplyMatrix(2);
        m2.PrintMatrix();
        Console.WriteLine();

        m4 = m2.AddMatrix(m3);
        m4.PrintMatrix();
        Console.WriteLine();

        m4 = m2.SubMatrix(m3);
        m4.PrintMatrix();
        Console.WriteLine();
    }
}
