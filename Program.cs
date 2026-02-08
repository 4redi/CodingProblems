using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        var res = OrderFHalf.Order([2,7,3,5,6,7]);
        foreach(var i in res)
        {
            Console.WriteLine(string.Join(", ", i));
        }
    }
}



