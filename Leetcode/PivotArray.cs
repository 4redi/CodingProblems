public class SolutionPivot
{
    public int[] PivotArray(int[] nums, int pivot)
    {
        int[] res = new int[nums.Length];
        int left = 0, right = nums.Length - 1;
        for (int i = 0, j = nums.Length - 1; i < nums.Length; i++, j--)
        {
            if (nums[i] < pivot)
            {
                res[left] = nums[i];
                left++;
            }
            if (nums[j] > pivot)
            {
                res[right] = nums[j];
                right--;
            }
        }
        while (left <= right)
        {
            res[left] = pivot;
            left++;
        }
        return res;
    }
}