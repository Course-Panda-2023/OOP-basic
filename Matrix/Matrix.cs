class Matrix
{
    private double[,] _matrix;

    public Matrix(int width, int height)
    {
        this._matrix = new double[width, height];
    }

    public Matrix(Matrix mat)
    {
        this._matrix = mat._matrix;
    }

    public double[,] GetMatrix()
    {
        return _matrix;
    }
    public double GetValueAt(int row, int col)
    {
        return _matrix[row, col];
    }

    public double SumRow(int row)
    {
        int colLength = _matrix.GetLength(1);
        double sum = 0;
        for (int i = 0; i < colLength; i++)
        {
            sum += _matrix[row, i];
        }
        return sum;
    }

    public double SumCol(int col)
    {
        int rowLength = _matrix.GetLength(0);
        double sum = 0;
        for (int i = 0; i < rowLength; i++)
        {
            sum += _matrix[col, i];
        }
        return sum;
    }

    public bool CompareSums(Matrix matrix2)
    {
        double sum1 = 0;
        double sum2 = 0;
        //general sum function
        for (int i = 0; i < _matrix.GetLength(0); i++)
        {
            sum1 += SumRow(i);
        }
        for (int j = 0; j < matrix2._matrix.GetLength(0); j++)
        {
            sum2 += SumRow(j);
        }

        return sum1 == sum2;
    }
    public static Matrix operator *(int num, Matrix mat)
    {
        Matrix newMatrix = new Matrix(mat._matrix.GetLength(0), mat._matrix.GetLength(1));
        for (int i = 0; i < mat._matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mat._matrix.GetLength(1); j++)
            {
                newMatrix._matrix[i, j] = mat.GetValueAt(i, j) * num;
            }
        }
        return newMatrix;
    }

    public static Matrix operator +(Matrix mat1, Matrix mat2)
    {
        Matrix newMatrix = new Matrix(mat1._matrix.GetLength(0), mat1._matrix.GetLength(1));
        for (int i = 0; i < mat1._matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mat1._matrix.GetLength(1); j++)
            {
                newMatrix._matrix[i, j] = mat1.GetValueAt(i, j) + mat2.GetValueAt(i, j);
            }
        }
        return newMatrix;
    }

    public static Matrix operator -(Matrix mat1, Matrix mat2)
    {
        Matrix newMatrix = new Matrix(mat1._matrix.GetLength(0), mat1._matrix.GetLength(1));
        for (int i = 0; i < mat1._matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mat1._matrix.GetLength(1); j++)
            {
                newMatrix._matrix[i, j] = mat1.GetValueAt(i, j) - mat2.GetValueAt(i, j);
            }
        }
        return newMatrix;
    }

}