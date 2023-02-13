using System;
using MatrixClass;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix m1 = new Matrix(3, 3);
            Matrix m2 = new Matrix(3, 2);
            m1.SetValueAt(2, 2, 1);
            m2.SetValueAt(2, 1, 1);
            m1.SetValueAt(2, 0, 1);
            m1.SetValueAt(2, 1, 3);
            m2.SetValueAt(1, 1, 3);
            m2.SetValueAt(2, 0, 4);

            //m1.CompareSums(m2);
            //Console.WriteLine(m1.CompareSums(m2));
            //Console.WriteLine(m1.SumColumn(1));
            m1.MatrixSubtraction(m2);
            m1.PrintMatrix();

        }
    }
}