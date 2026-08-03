using System;

public class Solution1406
{
    public string StoneGameIII(int[] st)
    {
        int n = st.Length;
        int[] dp = new int[n + 1];

        for (int i = n - 1; i >= 0; i--)
        {
            int diff = int.MinValue, take = 0;
            for (int j = 1; j <= 3; j++)
            {
                if (i + j - 1 < n)
                {
                    take += st[i + j - 1];
                    diff = Math.Max(diff, take - dp[i + j]);
                }
            }
            dp[i] = diff;
        }

        if (dp[0] > 0) return "Alice";
        else if (dp[0] < 0) return "Bob";
        else return "Tie";
    }
}