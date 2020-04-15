using System;

namespace Samples.CleanCodeApproach
{
  public class TriangleValidator : ITriangleValidator
  {
    private Point3D _point1;
    private Point3D _point2;
    private Point3D _point3;
    private Vector _vectorPoint1Point2;
    private Vector _vectorPoint1Point3;
    private const string EqualPointsError = "Can not use same points to calculate triangle perimeter";
    private const string CollinearPointsError = "Can not use collinear points to calculate triangle perimeter";

    public void CheckIfTriangleCanBeBuilt(Point3D point1, Point3D point2, Point3D point3)
    {
      AssignPoints(point1, point2, point3);
      CheckPointsForEquality();
      CheckPointsForCollinearity();
    }

    private void CheckPointsForEquality()
    {
      if (_point1.Equals(_point2) || _point1.Equals(_point3) || _point2.Equals(_point3))
      {
        throw new ArgumentException(EqualPointsError, nameof(TriangleValidator));
      }
    }

    private void CheckPointsForCollinearity()
    {
      AssignVectors();
      // If vector AB parallel to AC, then points A, B and C are collinear
      CheckIfVectorsParallel();
    }

    private void CheckIfVectorsParallel()
    {
      if (_vectorPoint1Point2.IsParallelToVector(_vectorPoint1Point3))
      {
        throw new ArgumentException(CollinearPointsError, nameof(TriangleValidator));
      }
    }

    private void AssignPoints(Point3D point1, Point3D point2, Point3D point3)
    {
      _point1 = point1;
      _point2 = point2;
      _point3 = point3;
    }

    private void AssignVectors()
    {
      _vectorPoint1Point2 = new Vector(_point2 - _point1);
      _vectorPoint1Point3 = new Vector(_point3 - _point1);
    }
  }
}