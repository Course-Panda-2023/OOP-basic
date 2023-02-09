using System;
using System.Reflection.Metadata.Ecma335;

public class Matrix
{
    private double[,] matrix;

    public int GetRowAmount() { return matrix.GetLength(0); }
    public int GetColAmount() { return matrix.GetLength(0); }

    public void SetValueAt(int i, int j, double value) { matrix[i, j] = value; }

    public Matrix(double[,] m)
    {
        matrix = new double[m.GetLength(0), m.GetLength(1)];
        for (int i = 0; i < m.GetLength(0); i++)
            for (int j = 0; j < m.GetLength(1); j++)
                matrix[i, j] = m [i, j];
    }

    public Matrix(Matrix m)
    {
        matrix = new double[m.GetRowAmount(), m.GetColAmount()];
        for (int i = 0; i < m.GetRowAmount(); i++)
            for (int j = 0; j < m.GetColAmount(); j++)
                matrix[i, j] = m.GetValueAt(i, j);
    }

    public Matrix (int row, int col)
    {
        matrix = new double[row, col];
    }

    public double GetValueAt(int row, int col)
    {
        return matrix[row - 1, col - 1];
    }

    public double SumRow(int row)
    {
        return SumHelper(row - 1, matrix.GetLength(1), 'r');
    }

    public double SumColumn(int col)
    {
        return SumHelper(col - 1, matrix.GetLength(0), 'c');
    }

    public double SumHelper (int place, int numsToSum, char rc)
    {
        double sum = 0;
        for (int i = 0; i < numsToSum; i++)
        {
            if (rc == 'r')
                sum += matrix[place, i];
            else
                sum += matrix[i, place];
        }
        return sum;
    }
    
    public bool CompareSums(Matrix m)
    {
        double mSum = sumMatrix(m);
        double currentMatrixSum = sumMatrix(this);

        return (currentMatrixSum == mSum);
    }
    
    public double sumMatrix(Matrix m)
    {
        double sum = 0;
        for (int i = 0; i < m.GetRowAmount(); i++)
            sum += m.SumRow(i + 1);
        return sum;
    }

    public Matrix MultiplyMatrix (int scalar)
    {
        Matrix m = new Matrix(matrix.GetLength(0), matrix.GetLength(1));
        for (int i = 0; i < matrix.GetLength(0); i++)
            for (int j = 0; j < matrix.GetLength(1); j++)
                m.SetValueAt(i, j, GetValueAt(i + 1, j + 1) * scalar);
        return m;
    }

    public Matrix AddMatrix(Matrix m)
    {
        return Operators(m, '+');
    }

    public Matrix SubMatrix(Matrix m)
    {
        return Operators(m, '-');
    }

    public Matrix Operators(Matrix m, char c)
    {
        Matrix newM = new Matrix (matrix.GetLength(0), matrix.GetLength(1));
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                if (c == '+')
                    newM.SetValueAt(i, j, m.GetValueAt(i + 1, j + 1) + matrix[i, j]);
                else
                    newM.SetValueAt(i, j, matrix[i, j] - m.GetValueAt(i + 1, j + 1));
            }
        }
        return newM;
    }

    public void PrintMatrix()
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(GetValueAt(i + 1, j + 1) + " ");
            }
            Console.WriteLine();
        }
    }
}