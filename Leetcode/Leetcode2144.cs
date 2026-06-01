public class Solution2144
{
    public int MinimumCost(int[] cost)
    {
        Array.Sort(cost);
        Array.Reverse(cost);

        int n = cost.Length, res = 0;
        for (int i = 0; i < n; i++)
        {
            if (i % 3 != 2)
            {
                res += cost[i];
            }
        }
        return res;
    }
}