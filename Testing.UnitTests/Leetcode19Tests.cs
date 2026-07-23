using Xunit;

namespace Leetcode19.Tests
{
    public class UnitTest1
    {
        [Fact]
        [Trait("Category", "LeetCode19")]
        public void Test1()
        {
            var solution = new Leetcode19Solution();
            var head = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
            int n = 2;
            var result = solution.RemoveNthFromEnd(head, n);
            Assert.Equal(new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(5)))), result);
        }
        [Fact]
        [Trait("Category", "LeetCode19")]
        public void Test2()
        {
            var solution = new Leetcode19Solution();
            var head = new ListNode(1);
            int n = 1;
            var result = solution.RemoveNthFromEnd(head, n);
            Assert.Null(result);
        }
        [Fact]
        [Trait("Category", "LeetCode19")]
        public void Test3()
        {
            var solution = new Leetcode19Solution();
            var head = new ListNode(1, new ListNode(2));
            int n = 1;
            var result = solution.RemoveNthFromEnd(head, n);
            Assert.Equal(new ListNode(1), result);
        }
    }
}