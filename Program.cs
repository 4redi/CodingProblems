using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        Transpose trans = new Transpose();
        int[,] matrix = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 9, 10 } };
        trans.TransposeMe(matrix);
    }
}



