class MoveZeroesToEnd
{
    public static void Move(int[] arr)
    {
        // [1,0,2,3] -> [1,2,3,0]

        int count = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                int temp = arr[i];
                arr[i] = arr[count];
                arr[count] = temp;

                count++;
            }
        }
    }
}