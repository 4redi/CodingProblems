    using System.Collections.Generic;
class Program
{
    public static void Main(string[] args)
    {
        AreaOfLargestSquare area=new AreaOfLargestSquare();
    int[][] bl = new int[][] {
            new int[] { 0, 0 },
            new int[] { 1, 1 },
            new int[] { 2, 2 }
        };
    int[][] tr = new int[][] {
            new int[] { 3, 3 },
            new int[] { 4, 4 },
            new int[] { 5, 5 }
        };
    long result = area.largestSquareArea(bl, tr);
    Console.WriteLine(result);
        }}



