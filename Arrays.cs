    using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Square.SqrtWithoutSqrt(64));
        bool ans = PrimeOrNot.FindIt(5);
        if (ans)
        {
            Console.WriteLine("It is a prime number");
        }
        else
        {
            Console.WriteLine("It is not a prime number");
        }

        
    }
}
