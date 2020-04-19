using Moq;
using NUnit.Framework;
using Samples.CleanCodeApproach;

namespace UnitTests.CleanCodeApproachTests
{
  public class TrianglePerimeterCalculatorTests
  {
    [Test]
    public void Calculate_Uses_TriangleValidator_To_Validate_The_Input_Data()
    {
      var _triangleValidatorMock = new Mock<ITriangleValidator>();
      var perimeterCalculator = new TrianglePerimeterCalculator(_triangleValidatorMock.Object);

      var point1 = new Point3D(6, 0, 0);
      var point2 = new Point3D(0, 6, 0);
      var point3 = new Point3D(0, 0, 0);

      perimeterCalculator.Calculate(point1, point2, point3);

      _triangleValidatorMock
        .Verify(m => m.CheckIfTriangleCanBeBuilt(It.IsAny<Point3D>(), It.IsAny<Point3D>(), It.IsAny<Point3D>())
        , Times.Once());
    }

    [Test]
    public void Calculate_Result_For_Three_Valid_Triangle_Coordinates_Is_Correctl()
    {
      var _triangleValidatorMock = new Mock<ITriangleValidator>();
      var perimeterCalculator = new TrianglePerimeterCalculator(_triangleValidatorMock.Object);

      var point1 = new Point3D(6, 0, 0);
      var point2 = new Point3D(0, 6, 0);
      var point3 = new Point3D(0, 0, 0);

      var result = perimeterCalculator.Calculate(point1, point2, point3);

      Assert.AreEqual(20.4852, result, 0.001);
    }
  }
}
