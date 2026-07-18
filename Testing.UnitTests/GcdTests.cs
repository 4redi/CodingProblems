using Xunit;

namespace Testing.UnitTests
{
    public class GcdTests
    {
        [Fact]
        [Trait("Category", "GCD")]
        public void Test1()
        {
            var result = Gcd.findGcdRecursive(48, 18);
            Assert.Equal(6, result);
        }
        [Fact]
        [Trait("Category", "GCD")]
        public void Test2()
        {
            var result = Gcd.findGcdRecursive(56, 98);
            Assert.Equal(14, result);
        }
        [Fact]
        [Trait("Category", "GCD")]
        public void Test3()
        {
            var result = Gcd.findGcdRecursive(101, 10);
            Assert.Equal(1, result);
        }
        [Fact]
        [Trait("Category","GCD")]
        public void Test4()
        {
            var result = Gcd.findGcdRecursive(0, 5);
            Assert.Equal(5, result);
        }
    }
}