using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
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
            get { return matrix[rowIndex, colIndex]; }
            set { matrix[rowIndex, colIndex] = (int)value; }
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

        unsafe public double SumRow(int row)
        {
            double result = 0.0;
            double* row = matrix[row];
            for (int i = 0; i < matrix.GetLength(1); ++i)
            {
                result += row[i];
            }
            return result;
        }
    }
}
