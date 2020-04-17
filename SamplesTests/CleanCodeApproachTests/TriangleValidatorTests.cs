using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Samples.CleanCodeApproach;

namespace UnitTests.CleanCodeApproachTests
{
  [TestClass]
  public class TriangleValidatorTests
  {
    private Point3D _point1 = new Point3D(1, 1, 1);
    private Point3D _point2 = new Point3D(3, 1, 10);
    private Point3D _point3 = new Point3D(11, 21, 31);

    private TriangleValidator _validator = new TriangleValidator();

    [TestMethod]
    [ExpectedException(typeof(ArgumentException),
      "Can not use same points to calculate triangle perimeter")]
    public void Exception_Is_Thrown_All_Points_Equal()
    {
      _validator.CheckIfTriangleCanBeBuilt(_point1, _point1, _point1);
    }

    [TestMethod]
    public void Exception_Is_Not_Thrown_For_Points()
    {
      _validator.CheckIfTriangleCanBeBuilt(_point1, _point2, _point3);
      Assert.IsTrue(true);
    }

    [TestMethod]
    [ExpectedException(typeof(ArgumentException),
      "Can not use collinear points to calculate triangle perimeter")]
    public void Exception_Is_Thrown_For_Parallel_Vectors()
    {
      var mockVector = new Mock<IVector>();
      mockVector.Setup(v => v.IsParallelToVector(It.IsAny<Vector>())).Returns(true);
      _validator.CheckIfTriangleCanBeBuilt(_point1, _point2, _point3);
    }

    [TestMethod]
    public void Exception_Is_Not_Thrown_For_Not_Parallel_Vectors()
    {
      var mockVector = new Mock<IVector>();
      mockVector.Setup(v => v.IsParallelToVector(It.IsAny<Vector>())).Returns(false);
      _validator.CheckIfTriangleCanBeBuilt(_point1, _point2, _point3);
    }
  }
}