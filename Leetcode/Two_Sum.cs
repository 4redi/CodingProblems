/*this is 
solved using the 2 pointer approach
*/
class Two_Sum
{
    public int TwoSum(int[] arr, int target)
    {
        Array.Sort(arr);
        int left = 0, right = arr.Length - 1;
        while (left < right)
        {
            int sum = arr[left] + arr[right];
            if (sum == target)
            {
                return 1; //found
            }
            else if (sum > target)
            {
                right--;
            }
            else
            {
                left++;
            }
        }
        return 0; //not found
    }
}