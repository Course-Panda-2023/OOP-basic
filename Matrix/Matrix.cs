using System;

public class Matrix
{
    private int[,] matrix;
    public int GetRowAmount() { return matrix.GetLength(0); }
    public void SetValueAt(int i, int j, int value) { matrix[i, j] = value; }

    public Matrix(int[,] m)
    {

    }

}