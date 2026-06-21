public class Solution
{
    public int MaxIceCream(int[] c, int coins)
    {
        int cnt = 0;
        int s = 0;
        Array.Sort(c);
        foreach (int i in c)
        {
            if (s + i <= coins)
            {
                s += i;
                cnt++;
            }
            else
            {
                break;
            }
        }
        return cnt;
    }
}