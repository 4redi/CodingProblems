using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        var res = OrderFHalf.Order([2,7,3,6,7,2]);
        foreach(var i in res)
        {
            Console.WriteLine(string.Join(", ", i));
        }
    }
}



