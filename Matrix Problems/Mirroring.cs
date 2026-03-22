class Mirroring
{
    public static void MirrorMatrix(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols / 2; j++)
            {
                int temp = matrix[i, j];
                matrix[i, j] = matrix[i, cols - 1 - j];
                matrix[i, cols - 1 - j] = temp;
            }
        }
    }
}