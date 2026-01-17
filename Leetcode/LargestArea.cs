

class AreaOfLargestSquare
{
    public long largestSquareArea(int[][] bl, int[][] tr)
    {
        int s = 0;
        int n = bl.Length;

        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                int minX = Math.Max(bl[i][0], bl[j][0]);
                int maxX = Math.Min(tr[i][0], tr[j][0]);
                int minY = Math.Max(bl[i][1], bl[j][1]);
                int maxY = Math.Min(tr[i][1], tr[j][1]);

                if (minX < maxX && minY < maxY)
                {
                    int size = Math.Min(maxX - minX, maxY - minY);
                    s = Math.Max(s, size);
                }
            }
        }
        return (long)s * s;
    }
}