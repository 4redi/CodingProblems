using System;
using System.Linq;

public class Solution3016
{
    public int MinimumPushes(string word)
    {
        int ans = 0;
        int[] freq = new int[26];

        for (int i = 0; i < word.Length; i++)
        {
            freq[word[i] - 'a']++;
        }

        freq = freq.OrderByDescending(i => i).ToArray();

        for (int i = 0; i < freq.Length; i++)
        {
            ans += freq[i] * (i / 8 + 1);
        }

        return ans;
    }
}