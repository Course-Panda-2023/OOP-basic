namespace OOP.Matrix;

public class Test
{
    public static void Main(string[] args)
    {
        Matrix m = new Matrix(4, 3);
        Console.WriteLine(m.GetValueAt(1, 2));
        m.SetValueAt(1, 2, 5);
        Console.WriteLine(m.GetValueAt(1, 2));

        Matrix m2 = new Matrix(4, 3);
        Console.WriteLine(m2.GetValueAt(1, 2));
        m2.SetValueAt(1, 2, 7);
        Console.WriteLine(m2.GetValueAt(1, 2));

        m = m * 4;
        Console.WriteLine(m.GetValueAt(1, 2));

        m2 = m2 * 3;
        Console.WriteLine(m2.GetValueAt(1, 2));
        
        Console.WriteLine(m.CompareSums(m2));

        Matrix m3 = m - m2;
        Console.WriteLine(m3.GetValueAt(1, 2));

        Matrix m4 = m + m2;
        Console.WriteLine(m4.GetValueAt(1, 2));
    }
}