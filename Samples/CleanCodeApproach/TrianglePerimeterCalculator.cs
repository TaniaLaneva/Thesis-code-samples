namespace Samples.CleanCodeApproach
{
  public class TrianglePerimeterCalculator
  {
    private Point3D _point1;
    private Point3D _point2;
    private Point3D _point3;
    private readonly ITriangleValidator _triangleValidator;

    public TrianglePerimeterCalculator(ITriangleValidator triangleValidator)
    {
      _triangleValidator = triangleValidator;
    }

    public double Calculate(Point3D point1, Point3D point2, Point3D point3)
    {
      _triangleValidator.CheckIfTriangleCanBeBuilt(point1, point2, point3);
      AssignPoints(point1, point2, point3);
      return CalculateTrianglePerimeter();
    }

    private double CalculateTrianglePerimeter()
    {
      return _point1.GetDistanceToPoint(_point2) + _point1.GetDistanceToPoint(_point3) +
             _point2.GetDistanceToPoint(_point3);
    }

    private void AssignPoints(Point3D point1, Point3D point2, Point3D point3)
    {
      _point1 = point1;
      _point2 = point2;
      _point3 = point3;
    }
  }
}