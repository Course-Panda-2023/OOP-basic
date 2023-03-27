// See https://aka.ms/new-console-template for more information
using System.Data.Common;

/* (tests)
//MatrixClass matrix_test = new MatrixClass(400, 400);
MatrixClass matrix_test1 = new MatrixClass(5,4);
matrix_test1.setValueAt(2, 2, 14.5);
matrix_test1.setValueAt(1,3, 2.25);
MatrixClass matrix_test2 = new MatrixClass(matrix_test1);
matrix_test2.setValueAt(2, 2, 10);
Console.WriteLine((matrix_test1 + matrix_test2).Sum());
*/




class MatrixClass
{
    double[,]? _values;
    int _cols, _rows;
    public MatrixClass(int rows, int cols)
    {
        _values = new double[rows, cols];
        _cols = cols;
        _rows = rows;
    }
    public MatrixClass(MatrixClass origin)
    {
        if (origin._values != null)
        {
            _values = origin._values.Clone() as double[,];
            _cols = origin._cols;
            _rows = origin._rows;
        }
    }
    public double GetValueAt(int row, int col)
    {
        if (_values != null)
        {
            return _values[row, col];
        }
        return 0;
    }
    public void setValueAt(int row, int col, double val)
    {
        if (_values != null)
        {
            if (row < _rows && col < _cols)
                _values[row, col] = val;
        }
    }
    public double SumRow(int row)
    {
        double result = 0;
        if (_values != null)
            for (int i = 0; i < _cols; i++)
                result += _values[row, i];
        return result;
    }
    public double SumColumn(int col)
    {
        double result = 0;
        if (_values != null)
            for (int i = 0; i < _rows; i++)
                result += _values[i, col];
        return result;
    }
    public double Sum()
    {
        double result = 0;
        if (_values != null)
            for (int i = 0; i < _cols; i++)
                for (int j = 0; j < _rows; j++)
                    result += _values[j, i];
        return result;
    }
    public bool CompareSums(MatrixClass compareTo)
    {
        if (Sum() == compareTo.Sum()) return true;
        return false;
    }
    public static MatrixClass operator *(MatrixClass matrix, double scalar)
    {
        MatrixClass result = new MatrixClass(matrix);
        if (result._values != null)
        {
            for (int i = 0; i < result._cols; i++)
                for (int j = 0; j < result._rows; j++)
                    result._values[j, i] *= scalar;

        }
        return result;
    }
    public static MatrixClass operator +(MatrixClass matrix1, MatrixClass matrix2)
    {
        MatrixClass result = new MatrixClass(matrix1);
        if ((result._values != null) && (matrix2._values != null))
        {
            for (int i = 0; i < result._cols; i++)
                for (int j = 0; j < result._rows; j++)
                    result._values[j, i] += matrix2._values[j, i];
        }
        return result;
    }
    public static MatrixClass operator -(MatrixClass matrix1, MatrixClass matrix2)
    {
        MatrixClass result = new MatrixClass(matrix1);
        if ((result._values != null) && (matrix2._values != null))
        {
            for (int i = 0; i < result._cols; i++)
                for (int j = 0; j < result._rows; j++)
                    result._values[j, i] -= matrix2._values[j, i];
        }
        return result;
    }
}