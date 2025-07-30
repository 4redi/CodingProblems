    using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        if (Sorted.Helper(arr))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
       }
        
    }
}
