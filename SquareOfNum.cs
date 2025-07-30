class Square
{
    public static int SqrtWithoutSqrt(int num)
    {
        // two approaches 1) Logarithm one 2) Binary Search
        int low = 1;
        int high = num;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (mid * mid == num)
            {
                return mid;
            }
            else if (mid * mid > num)
            {
                high = mid - 1;
            }
            else
            {
                low = mid + 1;
            }
        }
        return high;
    }
}