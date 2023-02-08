using System;

class Matrix
{
    private double[,] mat { get; set; }
    public Matrix(int width, int height)
    {
        mat = new double[width, height];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < width; j++)
            {
                mat[i, j] = 0;
            }
        }
    }

    public Matrix(double[,] matrix, int rows, int cols)
    {
        mat = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                mat[i, j] = matrix[i, j];
            }
        }
    }
    public Matrix(Matrix mat1)
    {
        this.mat = mat1.mat;
    }
    public double GetValueAt(int row, int col)
    {
        return mat[row, col];
    }
    public double SumRow(int row)
    {
        double sum = 0;
        for (int i = 0; i < mat.GetLength(1); i++)
        {
            sum += mat[row, i];
        }
        return sum;
    }
    public double SumColumn(int col)
    {
        double sum = 0;
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            sum += mat[i, col];
        }
        return sum;
    }

    public bool CompareSums(Matrix mat1)
    {
        double sumMyMatrix = 0;
        double sumMat1 = 0;
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            sumMyMatrix += SumRow(i);
        }
        for (int i = 0; i < mat1.mat.GetLength(0); i++)
        {
            sumMat1 += mat1.SumRow(i);
        }
        if (sumMyMatrix == sumMat1)
        {
            return true;
        }
        return false;
    }


    public static Matrix operator +(Matrix mat2, Matrix mat1)
    {
        Matrix temp = new Matrix(mat2.mat.GetLength(0), mat2.mat.GetLength(1));
        for (int i = 0; i < mat2.mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat2.mat.GetLength(1); j++)
            {
                temp.mat[i, j] = mat1.mat[i, j] + mat2.mat[i, j];
            }
        }
        return temp;
    }

    public static Matrix operator -(Matrix mat1, Matrix mat2)
    {
        Matrix temp = new Matrix(mat2.mat.GetLength(0), mat2.mat.GetLength(1));
        for (int i = 0; i < mat2.mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat2.mat.GetLength(1); j++)
            {
                temp.mat[i, j] = mat1.mat[i, j] + mat2.mat[i, j];
            }
        }
        return temp;
    }

    public static Matrix operator *(Matrix mat1, double num)
    {
        Matrix temp = new Matrix(mat1.mat.GetLength(0), mat1.mat.GetLength(1));
        for (int i = 0; i < mat1.mat.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.mat.GetLength(1); j++)
            {
                temp.mat[i, j] = mat1.mat[i, j] * num;
            }
        }
        return temp;
    }
    
}