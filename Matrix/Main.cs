using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        /*
        Test your class here
        */
        Matrix m = new Matrix();
        Matrix m1 = new Matrix(m);
        Matrix m2 = m*4;
        Matrix m3 = m +m2;
        Matrix m4 = m -m3;
    }
}
