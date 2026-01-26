public class Transpose
{
    public void TransposeMe(int[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        int[,] transposed = new int[cols, rows];
        for (int i = 0; i < rows; i++)
        {
            for(int j = 0; j < cols; j++)
            {
                transposed[j,i]= matrix[i,j];
            }
        }

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                System.Console.Write(transposed[i,j] + " ");
            }
        }
    }
}