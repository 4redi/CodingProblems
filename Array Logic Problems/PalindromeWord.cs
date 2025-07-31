class PalindromWord
{
    public static bool isPalindromeWord(string word)
    {
        char[] c = word.ToCharArray();
        Array.Reverse(c);

        return new string(c).Equals(word);
    }
}