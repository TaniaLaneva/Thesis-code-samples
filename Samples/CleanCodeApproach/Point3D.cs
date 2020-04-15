using System;

namespace Samples.CleanCodeApproach
{
  public class Point3D
  {
    public double X { get; }
    public double Y { get; }
    public double Z { get; }

    public Point3D(double x, double y, double z)
    {
      X = x;
      Y = y;
      Z = z;
    }

    public double GetDistanceToPoint(Point3D point)
    {
      return Math.Sqrt(Math.Pow(point.X - X, 2) + Math.Pow(point.Y - Y, 2) + Math.Pow(point.Z - Z, 2));
    }

    public static Point3D operator -(Point3D point1, Point3D point2) =>
      new Point3D(point1.X - point2.X, point1.Y - point2.Y, point1.Z - point2.Z);

    public override bool Equals(object? obj)
    {
      if (obj == null) return false;
      if (!(obj is Point3D point)) return false;
      return X.Equals(point.X) && Y.Equals(point.Y) && Z.Equals(point.Z);
    }

    public override int GetHashCode()
    {
      return HashCode.Combine(X, Y, Z);
    }
  }
}