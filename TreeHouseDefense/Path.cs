using System.Linq;

namespace TreeHouseDefense
{
    public class Path
    {
        private readonly MapLocation[] _mapLocations;

        public Path(MapLocation[] mapLocations)
        {
            _mapLocations = mapLocations;
        }

        public bool IsOnPath(MapLocation mapLocation)
        {
            return _mapLocations.Contains(mapLocation);
        }
    }
}