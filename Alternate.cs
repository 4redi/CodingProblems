class Alternate
{
    public static void Exercise1()
    {
        // [10,20,30,40] -> [10,30]

        int[] arr = { 10, 20, 30, 40, 60, 80, 100, 120 };
        //! Iterative approach
        for (int i = 0; i < arr.Length; i++)
        {
            if (i % 2 == 0)
            {
                Console.WriteLine(arr[i]);
            }
        }

        
    }
}