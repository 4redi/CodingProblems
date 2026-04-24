public class LeetCode2833
{
    public int FurthestDistanceFromOrigin(string moves)
    {
        int CountLeft = 0;
        int CountRight = 0;
        int CountScore = 0;

        foreach (var i in moves)
        {
            if (i == 'L')
            {
                CountLeft++;
            }
            else if (i == 'R')
            {
                CountRight++;
            }
            else
            {
                CountScore++;
            }
        }

        return Math.Abs(CountLeft - CountRight) + CountScore;
    }
}