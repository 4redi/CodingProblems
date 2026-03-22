using Xunit;

namespace LeetCode3070.Tests
{
    public class UnitTest1
    {
        [Fact]
        [Trait("Category", "LeetCode3070")]
        public void Test1()
        {
            int[][] grid = new int[][]
            {
                new int[]{7,6,3},
                new int[]{6,6,1}
            };
            int k = 18;

            var solution = new Problem3070();
            int result = solution.CountSubmatrices(grid, k);

            Assert.Equal(4, result);
        }

        [Fact]
        [Trait("Category", "LeetCode3070")]
        public void Test2()
        {
            int[][] grid = new int[][]
            {
                new int[]{1,1,1},
                new int[]{1,1,1},
                new int[]{1,1,1}
            };
            int k = 9;
            var solution = new Problem3070();
            int result = solution.CountSubmatrices(grid, k);
            Assert.Equal(9, result);

        }
        // Edge case: When grid is empty
        [Fact]
        [Trait("Category", "LeetCode3070")]
        public void Test3()
        {
            int[][] grid = new int[][]{
                new int[] { }
            };
            int k = 20;
            var solution = new Problem3070();
            int result = solution.CountSubmatrices(grid, k);
            Assert.Equal(0, result);

        }
    }
}