using System.Collections.Generic;
using System.Text;
using TreeHouseDefense;
using Xunit;
using Shouldly;


namespace TreeHouseDefenseTests
{
    public class PathTests
    {
        //Arrange
        private readonly Map _map;
        private readonly Path _sut;

        public PathTests()
        {
            _map = new Map(10,10);
             var pathLocations = new MapLocation[]
             {
                 new MapLocation(2, 3, _map),
                 new MapLocation(4, 5, _map),
                 new MapLocation(6, 7, _map),
                 new MapLocation(8, 9, _map),
             };
             _sut = new Path(pathLocations);
        }
        [Theory]
        [InlineData(2,3,true)]
        [InlineData(3,4,false)]
        public void Map_Location_IsOnPathTest(int x, int y, bool expected)
        {
            //Act
            var result = _sut.IsOnPath(new MapLocation(x,y,_map));
            //Assert
            result.ShouldBe(expected);

        }
       
    }
}
