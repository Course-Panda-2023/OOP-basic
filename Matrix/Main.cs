using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        Matrix mat = new Matrix(3,3);
        for (int i = 0; i<3; i++)
        {
            Console.Write("[");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(mat.GetVAlueAt(i,j) + " ");
            }
            Console.WriteLine("]");
        }
    }
}
