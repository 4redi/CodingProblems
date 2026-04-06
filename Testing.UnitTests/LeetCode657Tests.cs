using Xunit;


namespace Testing.UnitTests
{
    public class LeetCode657Tests
    {
        [Fact]
        [Trait("Category", "LeetCode657")]
        public void Test1()
        {
            var solution = new Leetcode657();
            Assert.True(solution.JudgeCircle("UD"));
        }
        [Fact]
        [Trait("Category", "LeetCode657")]
        public void Test2()
        {
            var solution = new Leetcode657();
            Assert.False(solution.JudgeCircle("LL"));
        }
        [Fact]
        [Trait("Category", "LeetCode657")]
        public void Test3()
        {
            var solution = new Leetcode657();
            Assert.True(solution.JudgeCircle("RRDLDLUU"));
        }
        [Fact]
        [Trait("Category", "LeetCode657")]
        public void Test4()
        {
            var solution = new Leetcode657();
            Assert.False(solution.JudgeCircle("RR"));
        }
    }
}