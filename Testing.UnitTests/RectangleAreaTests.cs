using Xunit;

namespace Area.Tests
{
    public class UnitTest2
    {
        [Fact]
        public void TestComputeArea_NoOverlap()
        {
            var solution = new Rect_Area();
            
            // Rectangle A: (0, 0) to (2, 2)
            // Rectangle B: (3, 3) to (5, 5)
            int ax1 = 0, ay1 = 0, ax2 = 2, ay2 = 2;
            int bx1 = 3, by1 = 3, bx2 = 5, by2 = 5;
            
            int result = solution.ComputeArea(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2);
            
            // Expected area = Area of A + Area of B
            // Area of A = (2-0) * (2-0) = 4
            // Area of B = (5-3) * (5-3) = 4
            // Total area = 4 + 4 = 8
            Assert.Equal(8, result);
        }

        [Fact]
        public void TestComputeArea_CompleteOverlap()
        {
            var solution = new Rect_Area();
            
            // Rectangle A: (0, 0) to (4, 4)
            // Rectangle B: (1, 1) to (3, 3) (completely inside A)
            int ax1 = 0, ay1 = 0, ax2 = 4, ay2 = 4;
            int bx1 = 1, by1 = 1, bx2 = 3, by2 = 3;
            
            int result = solution.ComputeArea(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2);
            
            // Expected area = Area of A (since B is fully inside A)
            // Area of A = (4-0) * (4-0) = 16
            Assert.Equal(16, result);
        }

        [Fact]
        public void TestComputeArea_PartialOverlap()
        {
            var solution = new Rect_Area();
            
            // Rectangle A: (0, 0) to (4, 4)
            // Rectangle B: (2, 2) to (6, 6)
            int ax1 = 0, ay1 = 0, ax2 = 4, ay2 = 4;
            int bx1 = 2, by1 = 2, bx2 = 6, by2 = 6;
            
            int result = solution.ComputeArea(ax1, ay1, ax2, ay2, bx1, by1, bx2, by2);
            
            // Expected area = Area of A + Area of B - Area of Overlap
            // Area of A = (4-0) * (4-0) = 16
            // Area of B = (6-2) * (6-2) = 16
            // Overlap width = 2, Overlap height = 2 (Top-left = (2,2), Bottom-right = (4,4))
            // Area of overlap = 2 * 2 = 4
            // Total area = 16 + 16 - 4 = 28
            Assert.Equal(28, result);
        }
    }
}
