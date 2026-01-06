public class MatrixOrient
{
    public void matrix(int[][] A)
    {
        int row = A.Length;
        int cols = A[0].Length;
        for (int j = 0; j < cols; j++)
        {
            if (j % 2 == 0)
            {
                for (int i = 0; i < row; i++)
                {
                    Console.WriteLine(A[i][j]);
                }
            }

            else
            {
                for (int i = row - 1; i >= 0; i--)
                {
                    Console.WriteLine(A[i][j]);
                }
            }
        }
    }

}
