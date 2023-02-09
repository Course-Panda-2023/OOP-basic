using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP-Basic
{
    public class Matrix
    {
        private double[,] matrixArray;
        private int rows;
        public int Rows
        {
            get { return rows; }
        }
        private int cols;
        public int Cols
        {
            get { return cols; }
        }


        public Matrix(int rows, int cols)
        {
            this.rows = rows;
            this.cols = cols;
            this.matrixArray = new double[rows, cols];
            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    this.matrixArray[row, col] = 0;
        }

        public Matrix(Matrix m)
        {
            this.rows = m.rows;
            this.cols = m.cols;
            this.matrixArray = new double[this.rows, this.cols];
            for (int row = 0; row < rows; row++)
                for (int col = 0; col < cols; col++)
                    this.matrixArray[row, col] = m.GetValueAt(row, col);
        }

        public double GetValueAt(int row, int col)
        {
            return this.matrixArray[row, col];
        }

        public void SetValueAt(int row, int col, double value)
        {
            this.matrixArray[row, col] = value;
        }

        public double SumRow(int row)
        {
            double sum = 0;
            for (int col = 0; col < this.cols; col++)
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

        public bool CompareSums(Matrix otherMatrix)
        {
            double sum = 0;
            for (int row = 0; row < this.rows; row++)
            {
                sum += this.SumRow(row);
            }

            double otherSum = 0;
            for (int row = 0; row < this.rows; row++)
            {
                otherSum += otherMatrix.SumRow(row);
            }

            return sum == otherSum;
        }

        public static Matrix operator *(Matrix m, double num)
        {
            Matrix newM = new Matrix(m.Rows, m.Cols);
            for (int row = 0; row < m.Rows; row++)
                for (int col = 0; col < m.Cols; col++)
                    newM.SetValueAt(row, col, num * m.GetValueAt(row, col));
            return newM;
        }

        public static Matrix operator +(Matrix m1, Matrix m2)
        {
            Matrix newM = new Matrix(m1.Rows, m1.Cols);
            for (int row = 0; row < m1.Rows; row++)
                for (int col = 0; col < m1.Cols; col++)
                    newM.SetValueAt(row, col, m1.GetValueAt(row, col) + m2.GetValueAt(row, col));
            return newM;
        }

        public static Matrix operator -(Matrix m1, Matrix m2)
        {
            Matrix newM = new Matrix(m1.Rows, m1.Cols);
            for (int row = 0; row < m1.Rows; row++)
                for (int col = 0; col < m1.Cols; col++)
                    newM.SetValueAt(row, col, m1.GetValueAt(row, col) - m2.GetValueAt(row, col));
            return newM;
        }

        public void PrintMatrix()
        {
            for (int row = 0; row < this.Rows; row++)
            {
                for (int col = 0; col < this.Cols; col++)
                {
                    Console.Write($"{this.GetValueAt(row, col)} ");
                }
            }
            Console.Write("\n");
        }
    }
}
