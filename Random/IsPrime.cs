class isPrime
{
    public void findIt(int num)
    {
        if (num <= 1)
        {
            Console.WriteLine("Not Prime");
            return;
        }
        for(int i = 2; i <= Math.Sqrt(num); i++)
        {
                        if(num % i == 0) { 
                Console.WriteLine("Not Prime");
                return;
            }
        }
        Console.WriteLine("Prime");
    }
}