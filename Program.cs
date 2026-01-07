    using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        //MatrixOrient matrixOrient = new MatrixOrient();
        //matrixOrient.matrix(new int[][]
        //{
        //    new int[] {0, 2, 0},
        //    new int[] {4, 5, 6},
        //    new int[] {7, 0, 9}
        //});

        MatrixSum matrixSum = new MatrixSum();
        int[] result = matrixSum.MatrixMaxSum(new int[][]
            {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        });
        Console.WriteLine("Row: " + result[0] + ", Max Sum: " + result[1]);
    }
}
