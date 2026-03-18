class _2dPrefixSum
{
    public int[,] _2dSum(int[][] grid)
    {
        int m = grid.Length;
        int n = grid[0].Length;
        int[,] prefixSum = new int[m, n];

        prefixSum[0, 0] = grid[0][0];

        for (int j = 1; j < n; j++)
        {
            prefixSum[0, j] = prefixSum[0, j - 1] + grid[0][j];
        }

        for (int i = 1; i < m; i++)
        {
            prefixSum[i, 0] = prefixSum[i - 1, 0] + grid[i][0];
        }

        for (int i = 1; i < m; i++)
        {
            for (int j = 1; j < n; j++)
            {
                prefixSum[i, j] = grid[i][j]
                    + prefixSum[i - 1, j]
                    + prefixSum[i, j - 1]
                    - prefixSum[i - 1, j - 1];
            }
        }

        return prefixSum;
    }
}