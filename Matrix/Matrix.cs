using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    internal class Matrix
    {
        private double[,] matrix;
        private int height;
        private int width;

        public Matrix(int height, int width)
        {
            double[,] matrix = new double[height, width];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    matrix[i, j] = 0;
                }
            }
            this.height = height;
            this.width = width;
            this.matrix = matrix;
        }

        public Matrix(double[,] matrix, int height, int width)
        {
            this.matrix = matrix;
            this.height = height;
            this.width = width;
        }

        public Matrix(Matrix m)
        {
            this.width = m.width;
            this.height = m.height;
            double[,] matrixCopy = new double[this.height, this.width];
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    matrixCopy[i, j] = m.matrix[i, j];
                }
            }
            this.matrix = matrixCopy;
        }

        public double GetValueAt(int row, int col)
        {
            return this.matrix[row, col];
        }

        public double SumRow(int row)
        {
            double sum = 0;
            for (int j = 0; j < this.width; j++)
            {
                sum += this.matrix[row, j];
            }
            return sum;
        }
        public double SumColumn(int column)
        {
            double sum = 0;
            for (int i = 0; i < this.height; i++)
            {
                sum += this.matrix[i, column];
            }
            return sum;
        }
        public bool CompareSums(Matrix other)
        {
            double thisSum = 0;
            double otherSum = 0;
            for (int i = 0; i < this.height; i++)
            {
                for (int j = 0; j < this.width; j++)
                {
                    thisSum += this.matrix[i, j];
                }
            }
            for (int i = 0; i < other.height; i++)
            {
                for (int j = 0; j < other.width; j++)
                {
                    otherSum += other.matrix[i, j];
                }
            }
            return thisSum == otherSum;
        }

        public Matrix OperatorMultiply(double scalar)
        {
            int height = this.height;
            int width = this.width;
            Matrix m = new Matrix(height, width);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    m.matrix[i, j] = scalar * this.matrix[i, j];
                }
            }
            return m;
        }

        public Matrix OperatorAdd(Matrix other)
        {
            int height = this.height;
            int width = this.width;
            Matrix m = new Matrix(height, width);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    m.matrix[i, j] = this.matrix[i, j] + other.matrix[i, j];
                }
            }
            return m;
        }

        public Matrix OperatorSubtract(Matrix other)
        {
            int height = this.height;
            int width = this.width;
            Matrix m = new Matrix(height, width);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    m.matrix[i, j] = this.matrix[i, j] - other.matrix[i, j];
                }
            }
            return m;
        }
    }
}
