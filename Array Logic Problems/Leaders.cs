class Leader
{

    public static List<int>Leaders(int[] arr)
    {
        List<int> results = new List<int>();
        int n = arr.Length;

        int maxRight = arr[n - 1];
        results.Add(maxRight);
        for (int i = n - 2; i >= 0; i--)
        {
            if (arr[i] > maxRight)
            {
                maxRight = arr[i];
                results.Add(maxRight);
            }
        }


        results.Reverse();
            return results;
}
}