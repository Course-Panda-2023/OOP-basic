using System;

namespace MatrixClass // Note: actual namespace depends on the project name.
{
    class Matrix
    {
        private int width;
        private int height;
        private double[,] matrixArray;

        public Matrix(Matrix m)
        {
            this.matrixArray = m.matrixArray;
        }

        public Matrix(int width, int height)
        {
            this.width = width;
            this.height = height;
            this.matrixArray = new double[width, height];
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    this.matrixArray.SetValue(0, i, j);
                }
            }
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
            double rowSum = 0;
            for (int i = 0; i < height; i++)
            {
                rowSum += matrixArray[row, i];
            }
            return rowSum;
        }

        public double SumColumn(int column)
        {
            double rowSum = 0;
            for (int i = 0; i < width; i++)
            {
                rowSum += matrixArray[i, column];
            }
            return rowSum;
        }

        public double getSum()
        {
            double sum = 0;
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    sum += matrixArray[i, j];
                }
            }
            return sum;
        }

        public Boolean CompareSums(Matrix OtherMatrix)
        {
            double thisSum = getSum();
            double otherSum = OtherMatrix.getSum();
            if (thisSum == otherSum)
            {
                return true;
            }
            return false;
        }

        public void MatrixAddition(Matrix OtherMatrix)
        {
            if ((width == OtherMatrix.width) && (height == OtherMatrix.height))
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        matrixArray[i, j] += OtherMatrix.GetValueAt(i, j);
                    }
                }
            }
            else
            {
                Console.WriteLine("could not add, matrix and other matrix arent same size");
            }
        }
        public void MatrixSubtraction(Matrix OtherMatrix)
        {
            if ((width == OtherMatrix.width) && (height == OtherMatrix.height))
            {
                for (int i = 0; i < width; i++)
                {
                    for (int j = 0; j < height; j++)
                    {
                        matrixArray[i, j] -= OtherMatrix.GetValueAt(i, j);
                    }
                }
            }
            else
            {
                Console.WriteLine("could not subtract, matrix and other matrix arent same size");
            }

        }

        public void MatrixMultipication(double scalar)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    matrixArray[i, j] *= scalar;
                }
            }
        }

        public void PrintMatrix()
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    Console.Write(matrixArray[i, j] + " ");
                }
                Console.WriteLine();
            }
        }


    }
}