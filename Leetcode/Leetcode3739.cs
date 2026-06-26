public class Solution3739
{
    public long CountMajoritySubarrays(int[] nums, int t)
    {
        int n = nums.Length;
        int[] p = new int[n * 2 + 1];
        p[n] = 1;
        int cnt = n;

        long ans = 0, sum = 0;

        for (int i = 0; i < n; i++)
        {
            if (nums[i] == t)
            {
                sum += p[cnt];
                cnt++;
                p[cnt]++;

            }
            else
            {
                cnt--;
                sum -= p[cnt];
                p[cnt]++;
            }
            ans += sum;
        }
        return ans;
    }
}