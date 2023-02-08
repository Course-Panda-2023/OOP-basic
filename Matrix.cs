using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace OOPtemporary
{
    public class Matrix
    {
        private int[,] MyMatrix { get; }

        public Matrix(int rowLen, int colLen)
        {
            this.MyMatrix= new int[rowLen, colLen];
            for (int rowIndex = 0; rowIndex < this.MyMatrix.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < this.MyMatrix.GetLength(1); colIndex++)
                {
                    this.MyMatrix[rowIndex, colIndex] = 0;
                }
            }
        }

        // Copy constructor.
        public Matrix(Matrix previousMatrix)
        {
            this.MyMatrix = previousMatrix.MyMatrix;
        }

        private int GetValueAt(int row, int col)
        {
            return this.MyMatrix[row, col];
        }

        private int SumRow(int row)
        {
            int rowSum = 0;

            for (int colIndex = 0; colIndex < this.MyMatrix.GetLength(1); colIndex++)
            {
                rowSum += this.MyMatrix[row, colIndex];
            }

            return rowSum;
        }

        private int SumColumn(int col)
        {
            int colSum = 0;

            for (int rowIndex = 0; rowIndex < this.MyMatrix.GetLength(0); rowIndex++)
            {
                colSum += this.MyMatrix[rowIndex, col];
            }

            return colSum;
        }

        private bool CompareSums(Matrix secondMatrix)
        {
            int sumLocalMatrix = 0;
            int sumSecondMatrix = 0;

            for (int rowIndex = 0; rowIndex < this.MyMatrix.GetLength(0); rowIndex++)
            {
                sumLocalMatrix += this.SumRow(rowIndex);
            }

            for (int rowIndex = 0; rowIndex < secondMatrix.MyMatrix.GetLength(0); rowIndex++)
            {
                sumSecondMatrix += secondMatrix.SumRow(rowIndex);
            }

            return sumLocalMatrix == sumSecondMatrix;
        }

        public static Matrix operator *(int number, Matrix matrix)
        {
            Matrix newMatrix = new Matrix(matrix);
            for (int rowIndex = 0; rowIndex < newMatrix.MyMatrix.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < newMatrix.MyMatrix.GetLength(1); colIndex++)
                {
                    newMatrix.MyMatrix[rowIndex, colIndex] *= number;
                }
            }

            return newMatrix;   
        }

        public static Matrix operator +(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix newMatrix = new Matrix(firstMatrix.MyMatrix.GetLength(0), firstMatrix.MyMatrix.GetLength(1));
            for (int rowIndex = 0; rowIndex < secondMatrix.MyMatrix.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < secondMatrix.MyMatrix.GetLength(1); colIndex++)
                {
                    newMatrix.MyMatrix[rowIndex, colIndex] = firstMatrix.MyMatrix[rowIndex,colIndex] + secondMatrix.MyMatrix[rowIndex, colIndex];
                }
            }

            return newMatrix;
        }

        public static Matrix operator -(Matrix firstMatrix, Matrix secondMatrix)
        {
            Matrix newMatrix = new Matrix(firstMatrix.MyMatrix.GetLength(0), firstMatrix.MyMatrix.GetLength(1));
            for (int rowIndex = 0; rowIndex < secondMatrix.MyMatrix.GetLength(0); rowIndex++)
            {
                for (int colIndex = 0; colIndex < secondMatrix.MyMatrix.GetLength(1); colIndex++)
                {
                    newMatrix.MyMatrix[rowIndex, colIndex] = firstMatrix.MyMatrix[rowIndex, colIndex] - secondMatrix.MyMatrix[rowIndex, colIndex];
                }
            }

            return newMatrix;
        }
    }
}
