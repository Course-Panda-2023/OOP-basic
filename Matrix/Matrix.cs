/*
Matrix class
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopBasic
{
    public class Matrix
    {
        private double[,] matrixArray;
        public Matrix(int row, int col)
        {
            this.matrixArray = new double[row, col];
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    this.matrixArray[i, j] = 0;
                }
            }
        }

        public Matrix(Matrix m)
        {
            this.matrixArray = new double[m.matrixArray.GetLength(0), m.matrixArray.GetLength(1)]; // GetLength(0)=rows , GetLength(1)=columns
            for (int i = 0; i < m.matrixArray.GetLength(0); i++)
                for (int j = 0; j < m.matrixArray.GetLength(1); j++)
                    this.matrixArray[i, j] = m.matrixArray[i, j];
        }

        public double GetValueAt(int row, int col)
        {
            return matrixArray[row, col];
        }

        public void SetValueAt(int row, int col, double value)
        {
            matrixArray[row, col] = value;
        }

        public double SumRow(int row)
        {
            double sum = 0;
            for (int i = 0; i < matrixArray.GetLength(1); i++)
            {
                sum += matrixArray[row, i];
            }
            return sum;
        }

        public double SumColumn(int col)
        {
            double sum = 0;
            for (int i = 0; i < matrixArray.GetLength(0); i++)
            {
                sum += matrixArray[i, col];
            }
            return sum;
        }

        public bool CompareSums(Matrix m)
        {
            double sumMatrixArray = 0;
            double sumM = 0;
            for (int i = 0; i < matrixArray.GetLength(0); i++)
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                    sumMatrixArray += matrixArray[i, j];
            for (int i = 0; i < matrixArray.GetLength(0); i++)
                for (int j = 0; j < matrixArray.GetLength(1); j++)
                    sumM += m.matrixArray[i, j];
            return sumMatrixArray == sumM;
        }

        public static Matrix operator *(Matrix m1, int skalar)
        {
            Matrix m3 = new Matrix(m1.matrixArray.GetLength(0), m1.matrixArray.GetLength(1));
            for (int i = 0; i < m1.matrixArray.GetLength(0); i++)
                for (int j = 0; j < m1.matrixArray.GetLength(1); j++)
                    m3.matrixArray[i, j] = m1.matrixArray[i, j] * skalar;
            return m3;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix m3 = new Matrix(m1.matrixArray.GetLength(0), m1.matrixArray.GetLength(1));
            for (int i = 0; i < m1.matrixArray.GetLength(0); i++)
                for (int j = 0; j < m1.matrixArray.GetLength(1); j++)
                    m3.matrixArray[i, j] = m1.matrixArray[i, j] + m2.matrixArray[i, j];
            return m3;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix m3 = new Matrix(m1.matrixArray.GetLength(0), m1.matrixArray.GetLength(1));
            for (int i = 0; i < m1.matrixArray.GetLength(0); i++)
                for (int j = 0; j < m1.matrixArray.GetLength(1); j++)
                    m3.matrixArray[i, j] = m1.matrixArray[i, j] - m2.matrixArray[i, j];
            return m3;
        }

    }
}
