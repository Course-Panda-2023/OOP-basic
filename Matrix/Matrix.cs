using System;

public class Matrix
{
    private double[,] matrixArray;
    private int rows;
    public string Rows
    {
        get { return rows; }
    }
    private int cols;
    public string Cols
    {
        get { return cols; }
    }


    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        this.matrixArray = new double[rows, cols];
        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                this.matrixArray[row, col] = 0;
            }
        }
    }

    public Matrix(double[,] matrixArray)
    {
        this.matrixArray = matrixArray;
    }

    public double GetValueAt(int row, int col)
    {
        return this.matrixArray[row, col]
    }

    public void SetValueAt(int row, int col, double value)
    {
        this.matrixArray[row, col] = value;
    }

    public double SumRow(int row)
    {
        double sum = 0;
        for (int col=0; col<this.cols; col++)
        {
            sum += this.matrixArray[row, col];
        }
        return sum;
    }

    public double SumColumn(int col)
    {
        double sum = 0;
        for (int row = 0; row < this.rows; row++)
        {
            sum += this.matrixArray[row, col];
        }
        return sum;
    }

    public bool CompareSums(double[,] otherMatrixArray)
    {
        double sum = 0;
        for (int row=0; row<this.rows; row++)
        {
            sum += this.SumRow(row)
        }

        double otherSum = 0;
        for (int row = 0; row < this.rows; row++)
            for (int col = 0; col < this.cols; col++)
                otherSum += otherMatrixArray[row, col];

        return sum == otherSum;
    }

    public static Matrix operator *(Matrix m, double num)
    {
        Matrix newM = new Matrix(m.Rows, m.Cols);
        for (int row = 0; row < m.Rows; row++)
            for (int col = 0; col < m.Cols; col++)
                newM.SetValueAt(row, col, num*m.GetValueAt(row, col);
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        Matrix newM = new Matrix(m1.Rows, m1.Cols);
        for (int row = 0; row < m1.Rows; row++)
            for (int col = 0; col < m1.Cols; col++)
                newM.SetValueAt(row, col, m1.GetValueAt(row, col) + m2.GetValueAt(row, col);
    }

    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        Matrix newM = new Matrix(m1.Rows, m1.Cols);
        for (int row = 0; row < m1.Rows; row++)
            for (int col = 0; col < m1.Cols; col++)
                newM.SetValueAt(row, col, m1.GetValueAt(row, col) - m2.GetValueAt(row, col);
    }

    public void PrintMatrix()
    {
        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Cols; col++)
            {
                global::System.Console.WriteLine();
            }
        }

    }
}
