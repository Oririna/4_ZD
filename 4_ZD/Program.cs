using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_ZD
{
    public struct Point : IEquatable<Point>
    {
        public Point(double x, double y)
            : this()
        {
            X = x;
            Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public bool Equals(Point p1)
        {
            return
                this.X == p1.X &&
                this.Y == p1.Y;
        }

        public double RangeeTo(Point p1)
        {
            double d = (this.X - p1.X) * (this.X - p1.X)  +
                (this.Y - p1.Y) * (this.Y - p1.Y);
            return Math.Sqrt(d);
        }
    }
}