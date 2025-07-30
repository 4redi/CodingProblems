class Sorted
{
    public static bool CheckIfSorted(int[] arr, int n)
    {
        //! iterative approach
        // for (int i = 1; i < arr.Length; i++)
        // {
        //     if (arr[i - 1] > arr[i])
        //     {
        //         return false;
        //     }
        // }
        // return true;

        //recursive approach
        if (n == 0 || n == 1)
        {
            return true;
        }
        else
        {
            return arr[n - 1] > arr[n - 2] && CheckIfSorted(arr, n - 1);
        }
    }

    public static bool Helper(int[] arr)
    {
        return CheckIfSorted(arr, arr.Length);
    }
}

