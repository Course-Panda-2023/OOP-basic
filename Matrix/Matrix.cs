using System;

class Matrix
{
    public double[, ] mat; // check encapsulation details.
    public int rows, cols;
    public Matrix(int rows, int cols) // Constructor
    {
        this.rows = rows;
        this.cols = cols;
        this.mat = new double[rows, cols];
        for(int i=0; i<rows; i++)
            for(int j=0; j<cols; j++)
                this.mat[i, j] = 0;
    }

    public Matrix(Matrix m1) // Copy Constructor
    {
        this.rows = m1.rows;
        this.cols = m1.cols;
        this.mat = new double[m1.rows, m1.cols];
        for(int i=0; i<rows; i++)
            for(int j=0; j<cols; j++)
                this.mat[i, j] = m1.mat[i, j];
    }

    public double GetValueAt(int row, int col)
    {
        return this.mat[row, col];
    }
    public void SetValueAt(int row, int col, double value)
    {
        this.mat[row, col] = value;
    }

    public double SumRow(int row)
    {
        double sum = 0;
        for(int j=0; j<this.cols; j++)
            sum += this.mat[row, j];
        return sum;
    }

    public double SumColumn(int col)
    {
        double sum = 0;
        for(int i=0; i<this.rows; i++)
            sum += this.mat[i, col];
        return sum;
    }
    
    // Helper function
    public double SumMatrix() // #TODO encap here too
    {
        double sum = 0;
        for (int i=0; i<this.rows; i++)
            sum += this.SumRow(i);
        return sum;
    }
    
    public bool CompareSums(Matrix m1)
    {
        return this.SumMatrix() == m1.SumMatrix(); 
    }


    public static Matrix operator *(Matrix m1, double scalar) // encap check, + - too
    {
        Matrix newMat = new Matrix(m1.rows, m1.cols);
        for(int i=0; i<newMat.rows; i++)
            for(int j=0; j<newMat.cols; j++)
                newMat.mat[i, j] = m1.GetValueAt(i, j)*scalar;
        return newMat;
    }

    public static Matrix operator +(Matrix m1, Matrix m2)
    {
        if (m1.rows != m2.rows || m1.cols != m2.cols)
            throw new InvalidOperationException("Matrices not the same size.");
        
        Matrix newMat = new Matrix(m1.rows, m1.cols);
        for(int i=0; i<newMat.rows; i++)
            for(int j=0; j<newMat.cols; j++)
                newMat.mat[i, j] = m1.GetValueAt(i, j) + m2.GetValueAt(i, j);
        return newMat;
    }

    public static Matrix operator -(Matrix m1, Matrix m2)
    {
        if (m1.rows != m2.rows || m1.cols != m2.cols)
            throw new InvalidOperationException("Matrices not the same size.");
        
        Matrix newMat = new Matrix(m1.rows, m1.cols);
        for(int i=0; i<newMat.rows; i++)
            for(int j=0; j<newMat.cols; j++)
                newMat.mat[i, j] = m1.GetValueAt(i, j) - m2.GetValueAt(i, j);
        return newMat;
    }

}
