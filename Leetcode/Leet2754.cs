public class Solution2754
{
    public int[] LeftRightDifference(int[] nums)
    {
        int n = nums.Length;
        int[] ans = new int[n];

        int lSum = 0;
        for (int i = 0; i < n; i++)
        {
            ans[i] = lSum;
            lSum += nums[i];
        }
        int rSum = 0;
        for (int i = n - 1; i >= 0; i--)
        {
            ans[i] = Math.Abs(ans[i] - rSum);
            rSum += nums[i];
        }
        return ans;

    }
}