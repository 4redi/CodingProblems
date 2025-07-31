class PrintSubArrays
{
    public static void SubArrays(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i; j <arr.Length; j++)
            {
                for (int k = i; k <= j; k++)
                {
                    Console.WriteLine(arr[k]);
                }
                Console.WriteLine();
            }
        }
    }
}