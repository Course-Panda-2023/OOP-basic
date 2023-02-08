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
    /// <summary>
    /// class represents a two dimension matrix
    /// </summary>
    internal class TwoDMatrix
    {
        private double[,] matrix;

        /********************* c'ctor ***********************/
        /// <summary>
        /// constructs a matrix
        /// </summary>
        /// <param name="rows">row count</param>
        /// <param name="cols">columns count</param>
        public TwoDMatrix(int rows, int cols)
        {
            matrix = new double[rows, cols];
        }

        /********************* copy c'ctor ***********************/

        /// <summary>
        /// copy a matrix via c'ctor
        /// </summary>
        /// <param name="twoDMatrix">another matrix</param>
        public TwoDMatrix(TwoDMatrix twoDMatrix)
        {
            this.matrix = new double[twoDMatrix.GetRowsLength(), twoDMatrix.GetColsLength()];

            this.matrix = (double[,])twoDMatrix.matrix.Clone();
        }

        /********************* indexer ***********************/

        /// <summary>
        /// indexer of the class
        /// </summary>
        /// <param name="rowIndex">index of the row</param>
        /// <param name="colIndex">index of the column</param>
        /// <returns></returns>
        public double this[int rowIndex, int colIndex]
        {
            get { return this.matrix[rowIndex, colIndex]; }
            set { this.matrix[rowIndex, colIndex] = (int)value; }
        }


        /********************* Getters ***********************/

        /// <summary>
        /// property of matrix field
        /// </summary>
        public double[,] Matrix
        {
            get { return matrix; }
        }

        /*************************** Functions ******************/

        /// <summary>
        /// gets the row length
        /// </summary>
        /// <returns>the row length</returns>
        public int GetRowsLength()
        {
            return matrix.GetLength(0);
        }

        /// <summary>
        /// gets the column length
        /// </summary>
        /// <returns>column length</returns>
        public int GetColsLength()
        {
            return matrix.GetLength(1);
        }

        /// <summary>
        /// gets a value of matrix
        /// </summary>
        /// <param name="row">row index</param>
        /// <param name="col">column index</param>
        /// <returns></returns>
        public double GetValueAt(int row, int col)
        {
            return matrix[row, col];
        }

        /// <summary>
        /// setter of a specific value of the matrix
        /// </summary>
        /// <param name="row">row index</param>
        /// <param name="col">column index</param>
        /// <param name="value">a value</param>
        public void SetValueAt(int row, int col, double value)
        {
            const int LESS_IS_NEGATIVE = 0;
            if (row < LESS_IS_NEGATIVE) return;
            if (col < LESS_IS_NEGATIVE) return;

            matrix[row, col] = value;
        }

        /// <summary>
        /// get the sum of certained row
        /// </summary>
        /// <param name="row">row index</param>
        /// <returns>sum of all in row</returns>
        public double SumRow(int row)
        {
            double result = 0.0;
            for (int j = 0; j < matrix.GetLength(1); ++j)
            {
                result += matrix[row, j];
            }
            return result;
        }

        /// <summary>
        /// get the sum of certained columm
        /// </summary>
        /// <param name="col">a column index</param>
        /// <returns>the sum of columns</returns>
        public double SumColumn(int col)
        {
            double result = 0.0;
            for (int i = 0; i < matrix.GetLength(0); ++i)
            {
                result += matrix[i, col];
            }
            return result;
        }

        /// <summary>
        /// calculates the sum of a matrix
        /// </summary>
        /// <param name="matrix">a matrix</param>
        /// <returns>the sum of a matrix</returns>
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
        
        /// <summary>
        /// compare two matrix sums
        /// </summary>
        /// <param name="twoDMatrix">another matrix</param>
        /// <returns>if the sums are equal</returns>
        public bool CompareSums(TwoDMatrix twoDMatrix)
        {
            bool EQUALS = true;
            bool NOT_EQUALS = true;

            return SumOfMatrix(twoDMatrix.matrix).Equals(SumOfMatrix(matrix)) ? EQUALS : NOT_EQUALS;
        }

        /// <summary>
        /// overload an * operator of scalar multiplication
        /// </summary>
        /// <param name="matrix">a matrix</param>
        /// <param name="scalar">a scalar</param>
        /// <returns>the matrix multiply by scalar</returns>
        public static TwoDMatrix operator * (TwoDMatrix matrix ,double scalar)
        {
            int row = matrix.GetRowsLength();
            int col = matrix.GetColsLength();
            TwoDMatrix twoDMatrix = new TwoDMatrix(row, col);
            for (int i = 0; i < row; ++i)
            {
                for (int j = 0; j < col; ++j)
                {
                    twoDMatrix[i, j] *= scalar; 
                }
            }
            
            return twoDMatrix;
        }

        /// <summary>
        /// adds two matrixes with + operator
        /// </summary>
        /// <param name="matrix">a matrix</param>
        /// <param name="anotherMatrix">an another matrix</param>
        /// <returns></returns>
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
                    twoDMatrix[i, j] += anotherMatrix.matrix[i, j];
                }
            }

            return twoDMatrix;
        }

        /// <summary>
        /// minus operator of two matrixes
        /// </summary>
        /// <param name="matrix">a matrix</param>
        /// <param name="anotherMatrix">an anotheer matrix</param>
        /// <returns></returns>
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
                    twoDMatrix[i, j] -= anotherMatrix.matrix[i, j];
                }
            }

            return twoDMatrix;
        }
    }
}
