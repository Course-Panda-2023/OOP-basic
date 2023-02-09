using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix A = new Matrix(3, 3);
            double[,] doubleArr = new double[3, 3] { { 1, 1, 1 }, { 1, 1, 1 }, { 1, 1, 1 } };
            Matrix B = new Matrix(doubleArr, 3, 3);
            Matrix C = A.OperatorAdd(B);
        }
    }
}