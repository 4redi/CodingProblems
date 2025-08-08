using Xunit;

namespace TwoSum.Tests
{
    
    public class Testing3
    {
        [Fact]
        public void Testing1()
        {
            int[] arr = { -7, 8, 1, 2, 3, 10 };
            int target = 5;
            var solution = new Two_Sum();
            int res = solution.TwoSum(arr, target);
            Assert.Equal(1, res);
            
}

    }
}