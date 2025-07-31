class PrimeOrNot
{
    public static bool FindIt(int num)
    {
        if (num == 1)
        {
            return false;
        }
        else
        {
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
                Console.WriteLine(i);
            }
        }
        return true;
    }
}