class prefixSum
{
    public int[] PrefixSum(int[] arr)
    {
        /* Psh: {20,10,50}
         * {20} iterimi 1
         * {20,30} iterimi 2
         * {20,30,80} iterimi 3
         */
        int n =arr.Length;
        int[] prefixSumArr = new int[n];
        prefixSumArr[0] = arr[0];
        for(int i=1; i<n; i++)
        {
            prefixSumArr[i] = prefixSumArr[i-1] + arr[i];

        }

        return prefixSumArr;
    }
}