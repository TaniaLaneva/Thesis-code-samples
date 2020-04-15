namespace Samples.CleanCodeApproach
{
  public class TrianglePerimeterCalculator
  {
    private readonly ITriangleValidator _triangleValidator;

    public TrianglePerimeterCalculator(ITriangleValidator triangleValidator)
    {
      _triangleValidator = triangleValidator;
    }

    public double Calculate(Point3D point1, Point3D point2, Point3D point3)
    {
      _triangleValidator.CheckIfTriangleCanBeBuilt(point1, point2, point3);
      return CalculateTrianglePerimeter(point1, point2, point3);
    }

    private double CalculateTrianglePerimeter(Point3D point1, Point3D point2, Point3D point3)
    {
      return point1.GetDistanceToPoint(point2) + point1.GetDistanceToPoint(point3) +
             point2.GetDistanceToPoint(point3);
    }
  }
}