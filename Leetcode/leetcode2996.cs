public class Solution2996
{
    public int MissingInteger(int[] nums)
    {
        int n = nums.Length;
        HashSet<int> seen = new HashSet<int>(n);
        foreach (int num in nums)
        {
            seen.Add(num);
        }
        int sum = nums[0];
        for (int i = 1; i < n; i++)
        {
            if (nums[i] != nums[i - 1] + 1) break;
            else sum += nums[i];
        }

        while (seen.Contains(sum))
        {
            sum++;
        }

        return sum;
    }
}