public class LeetCode2515
{
    public int ClosestTarget(string[] words, string target, int start)
    {
        int n = words.Length;
        for (int i = 0; i <= n / 2; i++)
        {
            if (words[(i + start) % n] == target || words[(start - i + n) % n] == target)
                return i;
        }
        return -1;
    }
}