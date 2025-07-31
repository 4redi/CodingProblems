class Reverse
{
    public static void Rev(int[] arr)
    {
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            Console.WriteLine(arr[i]);  
        }
    }
}