using OOPBasics;

double[,] matrix = { { 4, 5, 6 }, { 7, 8, 9 }, { 10, 11, 12 }, { 12, 13, 14 }, { 13, 14, 15 } };
double[,] anotherMatrix = { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 }, { 8, 9, 10 }, { 10, 11, 12 } };

TwoDMatrix dMatrix = new(matrix);
TwoDMatrix dAnotherMatrix = new(anotherMatrix);

dMatrix.SetValueAt(3, 3, 6.4);

double sumOfRow0 = dMatrix.SumRow(0);

double sumOfColumn0 = dAnotherMatrix.SumColumn(0);

bool sumOfMatrixes = dAnotherMatrix.CompareSums(dMatrix);

TwoDMatrix mult = dMatrix * 3;
TwoDMatrix add = dMatrix + dAnotherMatrix;
TwoDMatrix minus = dMatrix - dAnotherMatrix;

Console.ReadKey();