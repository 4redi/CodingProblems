public class MatrixSum
{
    public int[] MatrixMaxSum(int[][] A)
    {
        int row=A.Length;
        int cols=A[0].Length;
        int maxSum=int.MinValue;
        int[] result=new int[2];
        for(int i=0;i<row;i++){
            int currentSum=0;
            for(int j=0;j<cols;j++){
                currentSum+=A[i][j];
            }
            if(currentSum>maxSum){
                maxSum=currentSum;
                result[0]=i;
                result[1]=maxSum;
            }
        }
        return result;
    }
}