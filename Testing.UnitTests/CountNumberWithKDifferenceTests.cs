using System.Reflection;
using Xunit;

namespace Testing1.UnitTests
{

    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int[] arr = { 1, 3 };
            int k = 3;
            var sol = new Solution();
            int res = sol.CountKDifference(arr, k);
            Assert.Equal(0, res);


        }

        [Fact]
        public void Test2()
        {
            int[] arr = { 7, 10, 9, 12, 1 };
            int k = 3;
            var sol = new Solution();
            int res = sol.CountKDifference(arr, k);
            Assert.Equal(2, res);

        }
    }
}