using Shouldly;
using TreeHouseDefense;
using Xunit;


namespace TreeHouseDefenseTests
{
    public class MapLocationTests
    {
        [Fact]
        public void MapLocationTest_Should_Throw_OutOfBoundsException()
        {
            //Arrange
            int x = 234;
            int y = 435;
            var map = new Map(12,12);
            //Act & Assert
            Should.Throw<OutOfBoundsException>((() => new MapLocation(x,y,map))) ;
        }
        [Fact]
        public void InRangeOfTest()
        {
            //Arrange
            var map = new Map(3,3);
            var sut = new MapLocation(1,1,map);
            //Act
            var result = sut.InRangeOf(new MapLocation(2, 2, map), 2);
            //Assert
            result.ShouldBeTrue();
        }
    }
}