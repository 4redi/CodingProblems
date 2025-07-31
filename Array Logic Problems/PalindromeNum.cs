class Palindrome
{
    public static bool isPalindrome(int num)
    {
        int x = num;
        int rev = 0;
        while (num > 0)
        {
            int digit = num % 10;
            rev = (rev * 10) + digit;
            num = num / 10;
        }
        return x==rev;
    } 
}