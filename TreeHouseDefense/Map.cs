using System;
using System.Collections.Generic;
using System.Text;

namespace TreeHouseDefense
{
    public class Map
    {
        public Map(int height, int width)
        {
            if (width < 1 || height < 1 )
            {
                throw new ArgumentOutOfRangeException($"height or width","Map must be at least 1*1");
            }
            Height = height;
            Width = width;
        }

        public bool OnMap(Point point)
        {
            return (Height >= point.Y && point.Y > 0 && Width >= point.X && point.X > 0);
        }

        public int Width { get; }
        public int Height { get; }

    }
}
