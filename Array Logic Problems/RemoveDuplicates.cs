class RemoveDuplicates
{
    public static void RemoveDuplicate(int[] arr)
    {
        HashSet<int> st = new HashSet<int>();
        for (int i = 0; i < arr.Length; i++)
        {
            st.Add(arr[i]);
        }

        foreach (int res in st)
        {
            Console.WriteLine(res);
        }
    }
}