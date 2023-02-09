/*
Matrix class
*/
public class Matrix
{
    private int[,] mat;
    const int defaultVal = 0;
    public Matrix(int row, int col)
    {
        mat = new int[row, col];
        fillMat(row, col);
    }
    public Matrix(Matrix m)
    {
        mat = new int[m.mat.GetLength(0), m.mat.GetLength(1)];
        for (int i = 0; i < m.mat.GetLength(0); i++)
        {
            for (int j = 0; j < m.mat.GetLength(1); j++)
            {
                this.mat[i, j] = m.mat[i, j];
            }
        }
    }
    private void fillMat(int row, int col)
    {
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < col; j++)
            {
                this.mat[i, j] = defaultVal;
            }
        }
    }
    public int GetValueAt(int row, int col)
    {
        return this.mat[row, col];
    }
    int SumRow(int row)
    {
        int sum = 0;
        for (int i = 0; i < mat.GetLength(1); i++)
        {
            sum += mat[row, i];
        }
        return sum;
    }
    int SumCol(int col)
    {
        int sum = 0;
        for (int i = 0; i < mat.GetLength(0); i++)
        {
            sum += mat[i, col];
        }
        return sum;
    }
    bool CompareSums(Matrix matrix)
    {
        int sumThisMat = 0;
        int sumaOtherMat = 0;
        for (int i = 0; i < this.mat.GetLength(0); i++)
        {
            sumThisMat += SumRow(i);
        }

        for (int i = 0; i < matrix.mat.GetLength(0); i++)
        {
            sumaOtherMat += matrix.SumRow(i);
        }
        return (sumThisMat == sumaOtherMat);
    }
    public static Matrix operator *(Matrix m, int scalar)
    {
        for (int i = 0; i < m.mat.GetLength(0); i++)
        {
            for (int j = 0; j < m.mat.GetLength(1); j++)
            {
                m.mat[i, j] *= scalar;
            }
        }
        return m;
    }
    public static Matrix operator +(Matrix m, Matrix other)
    {
        Matrix newMat = new Matrix(m);
        for (int i = 0; i < m.mat.GetLength(0); i++)
        {
            for (int j = 0; j < m.mat.GetLength(1); j++)
            {
                newMat.mat[i, j] = m.mat[i, j] + other.mat[i, j];
            }
        }
        return newMat;
    }
    public static Matrix operator -(Matrix m, Matrix other)
    {
        Matrix newMat = new Matrix(m);
        for (int i = 0; i < m.mat.GetLength(0); i++)
        {
            for (int j = 0; j < m.mat.GetLength(1); j++)
            {
                newMat.mat[i, j] -= other.mat[i, j];
            }
        }
        return newMat;
    }
}