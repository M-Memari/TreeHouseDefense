using System;

namespace TreeHouseDefense
{
    public class Point
    {
        public Point(int y, int x)
        {
            Y = y;
            X = x;
        }

        public int X { get; }
        public int Y { get; }

        public double DistanceTo(Point point)
        {
            return Math.Sqrt(Math.Pow(X - point.X, 2) + Math.Pow(Y - point.Y, 2));
        }
    }
}
