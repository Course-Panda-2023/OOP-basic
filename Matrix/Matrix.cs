class Matrix
{
    private double[,] matrix;

    //Constructor
    public Matrix(int width, int height)
    {
        this.matrix = new double[width, height];
    }

    public Matrix(Matrix mat)
    {
        this.matrix = mat.matrix;
    }

    public double[,] GetMatrix()
    {
        return matrix;
    }
    public double GetValueAt(int row, int col)
    {
        return matrix[row, col];
    }

    public double SumRow(int row)
    {
        int colLength = matrix.GetLength(1);
        double sum = 0;
        for (int i = 0; i < colLength; i++)
        {
            sum += matrix[row, i];
        }
        return sum;
    }

    public double SumCol(int col)
    {
        int rowLength = matrix.GetLength(0);
        double sum = 0;
        for (int i = 0; i < rowLength; i++)
        {
            sum += matrix[col, i];
        }
        return sum;
    }

    public bool CompareSums(Matrix matrix2)
    {
        double sum1 = 0;
        double sum2 = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum1 += SumRow(i);
        }
        for (int j = 0; j < matrix2.matrix.GetLength(0); j++)
        {
            sum2 += SumRow(j);
        }

        return sum1 == sum2;
    }
    public static Matrix operator *(int num, Matrix mat)
    {
        Matrix newMatrix = new Matrix(mat.matrix.GetLength(0), mat.matrix.GetLength(1));
        for (int i = 0; i < mat.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mat.matrix.GetLength(1); j++)
            {
                newMatrix.matrix[i, j] = mat.GetValueAt(i, j) * num;
            }
        }
        return newMatrix;
    }

    public static Matrix operator +(Matrix mat1, Matrix mat2)
    {
        Matrix newMatrix = new Matrix(mat1.matrix.GetLength(0), mat1.matrix.GetLength(1));
        for (int i = 0; i < mat1.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.matrix.GetLength(1); j++)
            {
                newMatrix.matrix[i, j] = mat1.GetValueAt(i, j) + mat2.GetValueAt(i, j);
            }
        }
        return newMatrix;
    }

    public static Matrix operator -(Matrix mat1, Matrix mat2)
    {
        Matrix newMatrix = new Matrix(mat1.matrix.GetLength(0), mat1.matrix.GetLength(1));
        for (int i = 0; i < mat1.matrix.GetLength(0); i++)
        {
            for (int j = 0; j < mat1.matrix.GetLength(1); j++)
            {
                newMatrix.matrix[i, j] = mat1.GetValueAt(i, j) - mat2.GetValueAt(i, j);
            }
        }
        return newMatrix;
    }

}