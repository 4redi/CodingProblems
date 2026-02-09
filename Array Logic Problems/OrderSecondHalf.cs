class SecondHalf
{
    public static int[] order2(int[] arr)
    {
        for(int j = arr.Length - 2; j >= (arr.Length / 2); j--)
        {
            if (arr[j] > arr[j + 1])
            {
                int temp=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=temp;
            }
        }
        return arr;
    }
}