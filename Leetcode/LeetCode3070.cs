public class Problem3070
{
    public int CountSubmatrices(int[][] grid, int k)
    {
        int m = grid.Length, n = grid[0].Length;
        int ans = 0;
        int[,] ps = new int[m + 1, n + 1];
        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                ps[i + 1, j + 1] = grid[i][j] + ps[i, j + 1] + ps[i + 1, j] - ps[i, j];
                if (ps[i + 1, j + 1] <= k) ans++;
            }
        }
        return ans;
    }
}