using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasics
{
    internal class TwoDMatrix
    {
        private double[,] matrix;

        /********************* c'ctor ***********************/
        /// <summary>
        /// 
        /// </summary>
        /// <param name="rows"></param>
        /// <param name="cols"></param>
        public TwoDMatrix(int rows, int cols)
        {
            matrix = new double[rows, cols];
        }

        /********************* copy c'ctor ***********************/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="twoDMatrix"></param>
        public TwoDMatrix(TwoDMatrix twoDMatrix)
        {
            this.matrix = new double[twoDMatrix.GetRowsLength(), twoDMatrix.GetColsLength()];

            this.matrix = (double[,])twoDMatrix.matrix.Clone();
        }

        /********************* indexer ***********************/

        /// <summary>
        /// 
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="colIndex"></param>
        /// <returns></returns>
        public object this[int rowIndex, int colIndex]
        {
            get { return this.matrix[rowIndex, colIndex]; }
            set { this.matrix[rowIndex, colIndex] = (int)value; }
        }


        /********************* Getters ***********************/

        /// <summary>
        /// 
        /// </summary>
        public double[,] Matrix
        {
            get { return matrix; }
        }

        /*************************** Functions ******************/

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetRowsLength()
        {
            return matrix.GetLength(0);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int GetColsLength()
        {
            return matrix.GetLength(1);
        }

        public double GetValueAt(int row, int col)
        {
            return matrix[row, col];
        }

        public void SetValueAt(int row, int col, double value)
        {
            const int LESS_IS_NEGATIVE = 0;
            if (row < LESS_IS_NEGATIVE) return;
            if (col < LESS_IS_NEGATIVE) return;

            matrix[row, col] = value;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="row"></param>
        /// <returns></returns>
        public double SumRow(int row)
        {
            double result = 0.0;
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                result += matrix[row, j];
            }
            return result;
        }


        public double SumColumn(int col)
        {
            double result = 0.0;
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                result += matrix[i, col];
            }
            return result;
        }

        private double SumOfMatrix(double[,] matrix)
        {
            const double ERROR_OCCURED = -1.0;
            if (matrix is null) return ERROR_OCCURED;

            double sum = 0.0;
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
        

        public bool CompareSums(TwoDMatrix twoDMatrix)
        {
            bool EQUALS = true;
            bool NOT_EQUALS = true;

            return SumOfMatrix(twoDMatrix.matrix).Equals(SumOfMatrix(matrix)) ? EQUALS : NOT_EQUALS;
        }


        public static TwoDMatrix operator * (TwoDMatrix matrix ,double scalar)
        {
            int row = matrix.GetRowsLength();
            int col = matrix.GetColsLength();
            TwoDMatrix twoDMatrix = new TwoDMatrix(row, col);
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    twoDMatrix.matrix[i, j] *= scalar; 
                }
            }
            
            return twoDMatrix;
        }

        public static TwoDMatrix operator +(TwoDMatrix matrix, TwoDMatrix anotherMatrix)
        {
            int row = matrix.GetRowsLength();
            int col = matrix.GetColsLength();

            int anotherRow = anotherMatrix.GetRowsLength();
            int anotherCol = anotherMatrix.GetRowsLength();

            if (row != anotherRow || col != anotherCol)
            {
               // todo - throw an exception
            }
            TwoDMatrix twoDMatrix = new TwoDMatrix(row, col);
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    twoDMatrix.matrix[i, j] += anotherMatrix.matrix[i, j];
                }
            }

            return twoDMatrix;
        }


        public static TwoDMatrix operator -(TwoDMatrix matrix, TwoDMatrix anotherMatrix)
        {
            int row = matrix.GetRowsLength();
            int col = matrix.GetColsLength();

            int anotherRow = anotherMatrix.GetRowsLength();
            int anotherCol = anotherMatrix.GetRowsLength();

            if (row != anotherRow || col != anotherCol)
            {
                // todo - throw an exception
            }
            TwoDMatrix twoDMatrix = new TwoDMatrix(row, col);
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    twoDMatrix.matrix[i, j] -= anotherMatrix.matrix[i, j];
                }
            }

            return twoDMatrix;
        }
    }
}
