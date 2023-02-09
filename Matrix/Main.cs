using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Matrix m = new Matrix(3, 4);
        Console.WriteLine("The initial m Matrix:");
        m.PrintMatrix();

        m.SetValueAt(1, 2, 10);
        Console.WriteLine("The m Matrix after (1,2)=10:");
        m.PrintMatrix();

        Matrix m2 = new Matrix(m);
        Console.WriteLine("The initial m2 Matrix:");
        m2.PrintMatrix();

        m.SetValueAt(1, 3, 20);
        Console.WriteLine("The m Matrix after (1,3)=20:");
        m.PrintMatrix();

        m2.SetValueAt(2, 2, 30);
        Console.WriteLine("The m2 Matrix after (2,2)=30:");
        m2.PrintMatrix();

        Console.WriteLine($"The value of m in (2,2): {m.GetValueAt(2, 2)}");
        Console.WriteLine($"The value of m2 in (2,2): {m2.GetValueAt(2, 2)}");
        Console.WriteLine($"The sum row 1 of m: {m.SumRow(1)}");
        Console.WriteLine($"The sum col 2 of m: {m.SumColumn(2)}");
        Console.WriteLine($"Does m == m2? {m.CompareSums(m2)}");
        m.SetValueAt(2, 2, 10);
        Console.WriteLine("The m Matrix after (0,0)=100:");
        m.PrintMatrix();
        Console.WriteLine($"Does m == m2? {m.CompareSums(m2)}");

        Console.WriteLine("m * 2 =");
        (m * 2).PrintMatrix();

        Console.WriteLine("m + m2 =");
        (m + m2).PrintMatrix();

        Console.WriteLine("m - m2 =");
        (m - m2).PrintMatrix();
    }
}
