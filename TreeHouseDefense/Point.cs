using System;

namespace TreeHouseDefense
{
    public class Point : IEquatable<object>
    {
        public Point(int x, int y)
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

        public override bool Equals(object obj)
        {
            if (obj == null || GetType()!=obj.GetType())
            {
                return false;   
            }

            var point = obj as Point;
            return X == point.X && Y == point.Y;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return (X * 397) ^ Y;
            }
        }
    }
}
