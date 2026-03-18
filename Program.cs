using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        _2dPrefixSum prefixSum = new _2dPrefixSum();
        int[][] grid = new int[][]
        {
            new int[] {1, 2, 3},
            new int[] {4, 5, 6},
            new int[] {7, 8, 9}
        };
        int[,] result = prefixSum._2dSum(grid);
        int m = grid.Length;
        int n= grid[0].Length;
        for(int i=0; i<m; i++)
        {
            for(int j=0; j<n; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}



