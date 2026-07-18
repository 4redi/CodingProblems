class Gcd
{
    public static int findGcdRecursive(int a,int b)
    {
        if (b == 0) return a;
        return findGcdRecursive(b, a % b);
    }
}