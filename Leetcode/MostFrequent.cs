class MostFrequnt
{
    public int MaxFreqString(string s)
    {
        int maxConso = 0;
        int maxVowel = 0;
        int[] freq = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            int index = c - 'a';

            if ("aeiou".Contains(s[i]))
            {
                freq[index]++;
                maxVowel = Math.Max(maxVowel, freq[index]);
            }
            else
            {
                freq[index]++;
                maxConso = Math.Max(maxConso, freq[index]);
            }
        }
        return maxConso+maxVowel;
    }
}