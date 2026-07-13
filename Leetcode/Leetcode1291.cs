public class Solution1291
{
    public IList<int> SequentialDigits(int low, int high)
    {
        var tmp = "123456789";
        int n = 10;
        var res = new List<int>();
        int lowLen = low.ToString().Length;
        int highLen = high.ToString().Length;
        for (int length = lowLen; length < highLen + 1; length++)
        {
            for (int s = 0; s < n - length; s++)
            {
                int num = int.Parse(tmp.Substring(s, length));
                if (num >= low && num <= high)
                {
                    res.Add(num);
                }
            }
        }
        return res;


    }
}