public class Solution3754
{
	public long SumAndMultiply(int n)
	{
		if (n == 0) return 0;
		long x = 0, sum = 0, pos = 1;
		while (n > 0)
		{
			int d = n % 10;

			if (d != 0)
			{
				x += d * pos;
				sum += d;
				pos *= 10;
			}


			n /= 10;
		}
		return x * sum;
	}
}