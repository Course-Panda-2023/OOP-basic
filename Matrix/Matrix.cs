using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Matrix 
    {
        
        private double[,] _matrix;


        public Matrix(int n, int m)
        {
            _matrix = new double[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    _matrix[i, j] = 0;
                }
            }
        }        
        public Matrix(Matrix m)
        {
            _matrix = new double[m._matrix.GetLength(0), m._matrix.GetLength(1)];
            for (int i = 0; i < m._matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m._matrix.GetLength(1); j++)
                {
                    _matrix[i, j] = m._matrix[i, j];
                }
            }
        }

        public double this[int i, int j]
        {
            //used as GetValueAt
            get
            {
                return _matrix[i, j];
            }
            //used as SetValueAt
            set
            {
                _matrix[i, j] = value;
            }
        }
        public int GetLength(int i)
        {
            return _matrix.GetLength(i);
        }
        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            if (m1._matrix.GetLength(0) != m2._matrix.GetLength(0) || m1._matrix.GetLength(1) != m2._matrix.GetLength(1))
                throw new Exception("Matrices are not the same size");

            Matrix m = new Matrix(m1._matrix.GetLength(0), m1._matrix.GetLength(1));
            for (int i = 0; i < m._matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m._matrix.GetLength(1); j++)
                {
                    m._matrix[i, j] = m1._matrix[i, j] + m2._matrix[i, j];
                }
            }
            return m;
        }    
        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            {
            if (m1._matrix.GetLength(0) != m2._matrix.GetLength(0) || m1._matrix.GetLength(1) != m2._matrix.GetLength(1))
                throw new Exception("Matrices are not the same size");

            Matrix m = new Matrix(m1._matrix.GetLength(0), m1._matrix.GetLength(1));
            for (int i = 0; i < m._matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m._matrix.GetLength(1); j++)
                {
                        m._matrix[i, j] = m1._matrix[i, j] - m2._matrix[i, j];
                }
            }
            return m;
            }
        }
        public static Matrix operator *(Matrix matrix, double scalar)
        {
            Matrix m = new Matrix(matrix._matrix.GetLength(0), matrix._matrix.GetLength(1));
            for (int i = 0; i < m._matrix.GetLength(0); i++)
            {
                for (int j = 0; j < m._matrix.GetLength(1); j++)
                {
                    m._matrix[i, j] = scalar * matrix._matrix[i, j];
                }                    
            }
                
            return m;
        }

        public double SumRow(int row)
        {
            double sum = 0;
            for (int i = 0; i < _matrix.GetLength(1); i++)
            {
                sum += _matrix[row, i];
            }
            return sum;
        }
        public double SumColumn(int column)
        {
            double sum = 0;
            for (int j = 0; j < _matrix.GetLength(1); j++)
            {
                sum += _matrix[j, column];
            }
            return sum;
        }
        public double SumAll()
        {
            double sum = 0;
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                for (int j = 0; j < _matrix.GetLength(1); j++)
                {
                    sum += _matrix[i, j];
                }
            }
            return sum;
        }
        public bool CompareSums(Matrix matrix)
        {            
            double sum1 = 0;
            double sum2 = 0;
            
            for (int i = 0; i < _matrix.GetLength(0); i++)
            {
                sum1 += SumRow(i);
            }
            for (int i = 0; i < matrix._matrix.GetLength(0); i++)
            {
                sum2 += matrix.SumRow(i);
            }
            return sum1 == sum2;
        }

    }
}
