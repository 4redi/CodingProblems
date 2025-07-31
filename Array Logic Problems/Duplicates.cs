class Duplicates
{
    public static bool FindDuplicates(int[] arr)
    {
        // Iterative approach
        // for (int i = 0; i < arr.Length; i++)
        // {
        //     for (int j = i + 1; j < arr.Length; j++)
        //     {
        //         if (arr[i] == arr[j])
        //         {
        //             return true;
        //         }
        //     }
        // }
        // return false;

        // Hashset approach
        HashSet<int> st = new HashSet<int>();
        int n = arr.Length;

        for (int i = 0; i < arr.Length; i++)
        {
            if (st.Contains(arr[i]))
            {
                return true; //yes there are duplicates

            }
            else
            {
                st.Add(arr[i]); // no there aren't duplicates
            }
        }
        return false;

    } 
}