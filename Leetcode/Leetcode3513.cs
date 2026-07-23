public class Solution3513
{
    public int uniqueXorTriplets(int[] nums)
    {
        int n = nums.Length;
        if (n <= 2) return n;

        int mask = 0;
        foreach(int num in nums)
        {
            mask |= num;
        }
        return mask + 1;
    }
}