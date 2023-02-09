using System;

class Matrix
{
    private double[,] mMat { get; set; }
    public Matrix(int width, int height)
    {
        mMat = new double[width, height];
        for (int i = 0; i < width; i++)
        {
            for (int j = 0; j < width; j++)
            {
                mMat[i, j] = 0;
            }
        }
    }

    public Matrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        mMat = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                mMat[i, j] = matrix[i, j];
            }
        }
    }

    public Matrix(Matrix mat1) //deep copy
    {
        int r = mat1.mMat.GetLength(0);
        int c = mat1.mMat.GetLength(1);
        mMat = new double[r, c];
        for (int i = 0; i < r; i++)
        {
            for (int j = 0; j < c; j++)
            {
                this.mMat[i, j] = mat1.mMat[i, j];
            }
        }
    }

    public double GetValueAt(int row, int col)
    {
        return mMat[row, col];
    }

    public double SumRow(int row)
    {
        double sum = 0;
        for (int i = 0; i < mMat.GetLength(1); i++)
        {
            sum += mMat[row, i];
        }
        return sum;
    }

    public double SumColumn(int col)
    {
        double sum = 0;
        for (int i = 0; i < mMat.GetLength(0); i++)
        {
            sum += mMat[i, col];
        }
        return sum;
    }

    public double ComputeSum()
    {
        double sum = 0;
        for (int i = 0; i < mMat.GetLength(0); i++)
        {
            sum += SumRow(i);
        }
        return sum;
    }

    public bool CompareSums(Matrix mat1) //create sum function
    {
        double sumMyMatrix = ComputeSum();
        double sumMat1 = mat1.ComputeSum();
        if (sumMyMatrix == sumMat1)
            return true;
        return false;
    }


    public static Matrix operator +(Matrix mat2, Matrix mat1)
    {
        Matrix temp = new Matrix(mat2.mMat.GetLength(0), mat2.mMat.GetLength(1));
        for (int i = 0; i < mat2.mMat.GetLength(0); i++)
        {
            for (int j = 0; j < mat2.mMat.GetLength(1); j++)
            {
                temp.mMat[i, j] = mat1.mMat[i, j] + mat2.mMat[i, j];
            }
        }
        return temp;
    }

    public static Matrix operator -(Matrix mat1, Matrix mat2)
    {
        Matrix temp = new Matrix(mat2.mMat.GetLength(0), mat2.mMat.GetLength(1));
        for (int i = 0; i < mat2.mMat.GetLength(0); i++)
        {
            for (int j = 0; j < mat2.mMat.GetLength(1); j++)
            {
                temp.mMat[i, j] = mat1.mMat[i, j] + mat2.mMat[i, j];
            }
        }
        return temp;
    }

    public static Matrix operator *(Matrix mat1, double num)
    {
        Matrix temp = new Matrix(mat1.mMat.GetLength(0), mat1.mMat.GetLength(1));
        for (int i = 0; i < mat1.mMat.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.mMat.GetLength(1); j++)
            {
                temp.mMat[i, j] = mat1.mMat[i, j] * num;
            }
        }
        return temp;
    }
     
}