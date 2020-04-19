using NUnit.Framework;
using Samples.CleanCodeApproach;

namespace UnitTests.CleanCodeApproachTests
{
  public class Point3DTest
  {
    [Test]
    public void GetDistanceToPoint_Between_Two_Valid_Point3Ds_Returns_Valid_Distance()
    {
      var point1 = new Point3D(0, 1, 0);
      var point2 = new Point3D(0, 0, 0);

      var result = point1.GetDistanceToPoint(point2);

      Assert.AreEqual(1, result, 0.1);
    }

    [Test]
    public void GetDistanceToPoint_With_Same_Point3D_Returns_Zero()
    {
      var point1 = new Point3D(0, 0, 0);
      var point2 = new Point3D(0, 0, 0);

      var result = point1.GetDistanceToPoint(point2);

      Assert.AreEqual(0, result, 0.1);
    }
  }
}
