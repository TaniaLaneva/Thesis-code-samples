using NUnit.Framework;
using Samples.CleanCodeApproach;

namespace UnitTests.CleanCodeApproachTests
{
  public class VectorTests
  {
    [Test]
    public void IsParallelToVector_Checks_Two_Parallel_Vectors_And_Returns_True()
    {
      var point1 = new Point3D(1, 1, 1);
      var point2 = new Point3D(2, 2, 2);

      var vector1 = new Vector(point1);
      var vector2 = new Vector(point2);

      var result = vector1.IsParallelToVector(vector2);

      Assert.IsTrue(result);
    }

    [Test]
    public void IsParallelToVector_Checks_Two_NonParallel_Vectors_And_Returns_False()
    {
      var point1 = new Point3D(1, 1, 1);
      var point2 = new Point3D(1, 1, 10);

      var vector1 = new Vector(point1);
      var vector2 = new Vector(point2);

      var result = vector1.IsParallelToVector(vector2);

      Assert.IsFalse(result);
    }
  }
}
