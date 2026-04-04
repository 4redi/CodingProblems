public class 2075Solution
{
    public string DecodeCiphertext(string encodedText, int rows)
    {
        if (rows == 1) return encodedText;
        int N = encodedText.Length;
        int cols = N / rows;

        StringBuilder dec = new StringBuilder(N);

        for (int i = 0; i < cols; i++)
        {
            for (int j = 0, k = i; j < rows && k < cols; k++, j++)
            {
                dec.Append(encodedText[j * cols + k]);
            }
        }

        return dec.ToString().TrimEnd(' ');
    }
}