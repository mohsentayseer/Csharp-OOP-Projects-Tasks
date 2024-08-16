using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    public class Point3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }
        public Point3D()
        {
            X = Y = Z = 0;
        }
        public Point3D(int _x, int _y, int _z)
        {
            X = _x;
            Y = _y;
            Z = _z;
        }
        public override string ToString()
        {
            return $"Point Coordinates: ({X}, {Y}, {Z})";
        }
        public static explicit operator string(Point3D point)
        {
            return point.ToString();
        }
        public override bool Equals(object? obj)
        {
            var right = obj as Point3D;

            if (right is null) return false;

            if (object.ReferenceEquals(right, this)) return true;

            if (right.GetType() != this.GetType()) { return false; }

            return this.X == right.X && this.Y == right.Y;
        }
    }
}
