using TreeHouseDefense;
using Shouldly;
using Xunit;

namespace TreeHouseDefenseTests
{
    public class PointTests
    {
        [Fact]
        public void PointTest()
        {
            //Arrange
            int x = 23;
            int y = 32;
            //Act
            var sut = new Point(x,y);
            //Assert
            sut.X.ShouldBe(x);
            sut.Y.ShouldBe(y);
        }

        [Fact]
        public void DistanceToTest()
        {
            //Arrange
            var point = new Point(3,4);
            var sut = new Point(0,0);
            //Act
            var result = sut.DistanceTo(point);
            //Assert
            result.ShouldBe(5,2);
        }

        [Theory]
        [InlineData(3, 4, 3, 4, true)]
        [InlineData(null,3,3,3,false)]
        [InlineData(2,3,5,2,false)]
        public void EqualsTest(int firstPointX, int firstPointY, int secondPointX, int secondPointy, bool expected)
        {
            //Arrange
            var sut = new Point(firstPointX, firstPointY);
            var p2 = new Point(secondPointX,secondPointy);
            //Act
            var result = sut.Equals(p2);
            //Assert
            result.ShouldBe(expected);
        }

        [Theory]
        [InlineData(3, 4, 3, 4, true)]
        [InlineData(null,3,3,3,false)]
        [InlineData(2,3,5,2,false)]
        public void GetHasCode_Test(int firstPointX, int firstPointY, int secondPointX, int secondPointy, bool expected)
        {
            //Arrange
            var sut = new Point(firstPointX, firstPointY);
            var p2 = new Point(secondPointX,secondPointy);
            //Act
            var result = sut.GetHashCode()==p2.GetHashCode();
            //Assert
            result.ShouldBe(expected);
        }
    }
}