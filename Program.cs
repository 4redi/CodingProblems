    using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 1, 2, 0, 4, 0, 5 };
        MoveZeroesToEnd.Move(arr);
        foreach (int a in arr) {
            Console.WriteLine(a);
        }
    }
}
