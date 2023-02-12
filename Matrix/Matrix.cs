using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPBasic
{

    internal class Matrix
    {
        private double[,] myMatrix;
        public double[,] MyMatrix { get { return myMatrix; } set { myMatrix = value; } }


        public Matrix(int row,int col) {
            myMatrix = new double[row, col];
        }

        //

        public Matrix(double [,] matrix)
        {
            myMatrix = matrix;
        }
        //
        public Matrix(Matrix matrix)
        {
            double[,] copyMatrix = matrix.myMatrix;
            myMatrix = new double[copyMatrix.GetLength(0), copyMatrix.GetLength(1)];
            for (int i=0;i< copyMatrix.GetLength(0); i++)
            {
                for( int j = 0;j < copyMatrix.GetLength(1);j++)
                {
                    myMatrix[i,j] = copyMatrix[i,j];    
                }
            }
        }

        public double GetValueAt(int row, int col)
        {
            return myMatrix[row,col];   
        }

        public void SetValueAt(int row,int col,double value)
        {
            myMatrix[row,col] = value;      
        }
         public double SumRow(int row)
        {
            double sum = 0;
            int len=myMatrix.GetLength(1);  
            for(int i = 0; i < len; i++)
            {
                sum += myMatrix[row,i]; 
            }
            return sum;
        }

        public double SumColumn(int col)
        {
            double sum = 0;
            int len = myMatrix.GetLength(0);
            for (int i = 0; i < len; i++)
            {
                sum += myMatrix[i,col];
            }
            return sum;
        }

        public bool CompareSums(Matrix matrix)
        {
            double mySum = 0;
            double sum = 0;
            int rows = myMatrix.GetLength(0);
            int cols = myMatrix.GetLength(1); 
            int r=matrix.myMatrix.GetLength(0); 
            int c=matrix.myMatrix.GetLength(1);
            
            for (int i = 0; i < rows; i++)
            {
                for(int j = 0; j < cols; j++)
                {
                    mySum += myMatrix[i,j];   
                }
            }

            for (int i = 0; i < r; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    sum += matrix.myMatrix[i, j];
                }
            }


            return sum==mySum;
        }

        public static Matrix operator * (Matrix matrix1, int num)
        {
            Matrix ret = new Matrix(matrix1);
            int row =ret.myMatrix.GetLength (0);
            int col = ret.myMatrix.GetLength (1);
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    ret.myMatrix[i,j] *= num;   
                }
            }
            return ret;
        }

        public static Matrix operator + (Matrix matrix1, Matrix matrix2)
        {

            Matrix ret = new Matrix(matrix1);
            int row = ret.myMatrix.GetLength(0);
            int col = ret.myMatrix.GetLength(1);
            if (matrix1.myMatrix.GetLength(0) != matrix2.myMatrix.GetLength(0) || matrix1.myMatrix.GetLength(1) != matrix2.myMatrix.GetLength(1))
                return null;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    ret.myMatrix[i, j] += matrix2.myMatrix[i,j];
                }
            }
            return ret;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {

            Matrix ret = new Matrix(matrix1);
            int row = ret.myMatrix.GetLength(0);
            int col = ret.myMatrix.GetLength(1);
            if (matrix1.myMatrix.GetLength(0) != matrix2.myMatrix.GetLength(0) || matrix1.myMatrix.GetLength(1) != matrix2.myMatrix.GetLength(1))
                return null;
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < col; j++)
                {
                    ret.myMatrix[i, j] -= matrix2.myMatrix[i, j];
                }
            }
            return ret;
        }

        public double this[int row,int col]
        {

            get { return myMatrix[row,col]; }
            set { myMatrix[row,col] = value; }
        }
    }
}
