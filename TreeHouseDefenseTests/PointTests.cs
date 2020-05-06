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
            result.ShouldBe(5,tolerance:2);
        }
    }
}