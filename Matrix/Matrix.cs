using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Matrix
{
    private int rows;
    public int Rows
    {
        get { return rows; }
        set { rows = value; }
    }
    private int cols;
    public int Cols
    {
        get { return cols; }
        set { cols = value; }
    }
    private int[,]? myMatrix;
    public int[,]? MyMatrix
    {
        get { return myMatrix; }
        set { myMatrix = value; }
    }
    public Matrix(int rows, int cols)
    {
        this.rows = rows;
        this.cols = cols;
        this.myMatrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                myMatrix[i, j] = 0;
    }
    public Matrix(int[,] m, int row, int cols)
    {
        this.myMatrix = m;
        this.Rows = row;
        this.Cols = cols;
    }
    public Matrix(Matrix m)
    {
        this.rows = m.Rows;
        this.cols = m.Cols;
        this.myMatrix = new int[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                if (m.myMatrix != null)
                    this.myMatrix[i, j] = m.myMatrix[i, j];
    }
    public int? GetValueAt(int row, int column)
    {
        if (this.myMatrix != null)
            return this.myMatrix[row, column];
        return null;
    }
    public void SetValueAt(int row, int column, int value)
    {
        if (this.myMatrix != null)
            this.myMatrix[row, column] = value;
    }
    public int? SumRow(int row)
    {
        if (this.myMatrix != null)
        {
            int sum = 0;
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    if (i == row)
                        sum += this.myMatrix[i, j];
                }
            }
            return sum;
        }
        return null;
    }
    public int? SumColumn(int col)
    {
        if (this.myMatrix != null)
        {
            int sum = 0;
            for (int i = 0; i < this.Rows; i++)
            {
                for (int j = 0; j < this.Cols; j++)
                {
                    if (j == col)
                        sum += this.myMatrix[i, j];
                }
            }
            return sum;
        }
        return null;
    }
    public bool CompareSums(Matrix m)
    {
        int sumMyMatrix = 0;
        int sumOtherMatrix = 0;
        if (this.myMatrix != null && m.myMatrix != null)
        {
            for (int i = 0; i < this.Rows; i++)
                for (int j = 0; j < this.Cols; j++)
                    sumMyMatrix += this.myMatrix[i, j];
            for (int i = 0; i < m.Rows; i++)
                for (int j = 0; j < m.Cols; j++)
                    sumOtherMatrix += m.myMatrix[i, j];
            if (sumMyMatrix == sumOtherMatrix)
                return true;
            return false;
        }
        else
        {
            Console.WriteLine("At least one of the matrixes is NULL");
            return false;
        }
    }
    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        Matrix ret = new Matrix(m1.Rows, m1.Cols);
        if (ret.myMatrix != null && m1.myMatrix != null && m2.myMatrix != null)
        {
            for (int i = 0; i < ret.Rows; i++)
                for (int j = 0; j < ret.Cols; j++)
                    ret.myMatrix[i, j] = m1.myMatrix[i, j] + m2.myMatrix[i, j];
            return ret;
        }
        ret.myMatrix = null;
        return ret;
    }
    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        Matrix ret = new Matrix(m1.Rows, m1.Cols);
        if (ret.myMatrix != null && m1.myMatrix != null && m2.myMatrix != null)
        {
            for (int i = 0; i < ret.Rows; i++)
                for (int j = 0; j < ret.Cols; j++)
                    ret.myMatrix[i, j] = m1.myMatrix[i, j] - m2.myMatrix[i, j];
            return ret;
        }
        ret.myMatrix = null;
        return ret;
    }
    public static Matrix operator *(Matrix m, int skalar)
    {
        Matrix ret = new Matrix(m.Rows, m.Cols);
        if (ret.myMatrix != null && m.myMatrix != null)
        {
            for (int i = 0; i < ret.Rows; i++)
                for (int j = 0; j < ret.Cols; j++)
                    ret.myMatrix[i, j] = m.myMatrix[i, j] * skalar;
            return ret;
        }
        ret.myMatrix = null;
        return ret;
    }
}