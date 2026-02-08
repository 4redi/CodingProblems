class OrderFHalf
{
    public static int[] Order(int[] arr)
    {
        int n=arr.Length;
        int half=n/2;

        
            for(int j = 0; j < half - 1; j++)
            {
                if (arr[j] < arr[j + 1])
                {
                    int temp=arr[j];
                    arr[j]=arr[j+1];
                    arr[j+1]=temp;
                }
            }
        
        return arr;
    }
}