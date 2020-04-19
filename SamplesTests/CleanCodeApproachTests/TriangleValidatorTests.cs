using System;
using NUnit.Framework;
using Samples.CleanCodeApproach;

namespace UnitTests.CleanCodeApproachTests
{
  public class TriangleValidatorTests
  {
    [Test]
    public void CheckIfTriangleCanBeBuilt_Throws_Exception_With_Same_Points()
    {
      var point1 = new Point3D(0, 1, 0);
      var point2 = new Point3D(0, 0, 0);
      var point3 = new Point3D(0, 0, 0);

      var validator = new TriangleValidator();

      Assert.That(() => validator.CheckIfTriangleCanBeBuilt(point1, point2, point3),
        Throws.TypeOf<ArgumentException>()
        .With.Message.EqualTo("Can not use same points to calculate triangle perimeter (Parameter 'TriangleValidator')"));
    }

    [Test]
    public void CheckIfTriangleCanBeBuilt_Throws_Exception_With_Two_Parallel_Vectors()
    {
      var point1 = new Point3D(0, 1, 0);
      var point2 = new Point3D(0, 2, 0);
      var point3 = new Point3D(0, 3, 0);

      var validator = new TriangleValidator();

      Assert.That(() => validator.CheckIfTriangleCanBeBuilt(point1, point2, point3),
        Throws.TypeOf<ArgumentException>()
        .With.Message.EqualTo("Can not use collinear points to calculate triangle perimeter (Parameter 'TriangleValidator')"));
    }
  }
}
