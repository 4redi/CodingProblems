using System.Reflection;
using Xunit;

namespace Testing1.UnitTests{
    public class ThreeSumTests{
        [Fact]
        public void Test1(){
            int[] nums = {-1,0,1,2,-1,-4};
            var sol = new ThreeSumSolution();
            var res = sol.ThreeSum(nums);
            Assert.Equal(2, res.Count);
        }

        [Fact]
        public void Test2(){
            int[] nums = { 0, 1, 1 };
            var sol = new ThreeSumSolution();
            var res = sol.ThreeSum(nums);
            Assert.Equal(0, res.Count);
        }

        [Fact]
        public void Test3(){
            int[] nums={0,1,1};
            var sol = new ThreeSumSolution();
            var res = sol.ThreeSum(nums);
            Assert.Equal(0, res.Count);
        }
    }
}