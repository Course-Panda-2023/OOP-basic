// See https://aka.ms/new-console-template for more information
using OOPBasic;

Console.WriteLine("Hello, World!");
double[,] stam = { { 1, 2, 3 }, { 4, 5, 6 } };
Matrix matrix1 =new Matrix(stam);
double[,] stam2 = { { 9,8,7 }, { 6,5,4 } };
Matrix matrix2 = new Matrix(stam2);
//Matrix ret = matrix * 3;
Matrix ret = matrix1+matrix2;
for(int i =0; i < ret.MyMatrix.GetLength(0); i++)
{
    for(int j=0;j< ret.MyMatrix.GetLength(1); j++)
    {
        Console.WriteLine(ret[i, j]);
    }
}

