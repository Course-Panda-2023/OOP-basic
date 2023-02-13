using System;


public class MatrixMain
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int rows = 3;
        int cols = 3;
        
        // initialize matrix
        Matrix matrix1 = new Matrix(rows, cols);
        for (int i=0; i<rows; i++)
        {
            for (int j=0; j<cols; j++)
                matrix1.SetValueAt(i, j, random.NextDouble());
        }
        
        // get value at location 2,1
        Console.WriteLine(matrix1.GetValueAt(row: 2, col: 1));

        // get sum of first row
        Console.WriteLine(matrix1.SumRow(row: 0));

        // get sum of second column
        Console.WriteLine(matrix1.SumColumn(col: 1));


        // copy matrix
        Matrix matrix2 = new Matrix(matrix1);

        // check that sums are equal
        Console.WriteLine(matrix1.CompareSums(matrix2));

        // matrix addition
        Matrix matrix3 = matrix1 + matrix2;

        // matrix subtraction
        Matrix matrix4 = matrix1 + matrix2;

        // scalar multiplication
        double scalar = 2.5;
        Matrix matrix5 = matrix1 * scalar;

    }
}
