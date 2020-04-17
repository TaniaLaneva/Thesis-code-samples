using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Samples.CleanCodeApproach;

namespace UnitTests.CleanCodeApproachTests
{
  [TestClass]
  public class TrianglePerimeterCalculatorTests
  {
    private TrianglePerimeterCalculator _calculator;
    private Point3D _point1 = new Point3D(1, 2, 3);
    private Point3D _point2 = new Point3D(1, 2, 3);
    private Point3D _point3 = new Point3D(10, -2, 13);

    [TestMethod]
    public void Calculator_Return_Correct_Value()
    {
      Mock<ITriangleValidator> validator = new Mock<ITriangleValidator>();
      _calculator = new TrianglePerimeterCalculator(validator.Object);
      var actual = _calculator.Calculate(_point1, _point2, _point3);
      var expected = 28.071337695236398;
      Assert.AreEqual(actual, expected);
    }

    [TestMethod]
    public void Validator_Was_Called_Once()
    {
      Mock<ITriangleValidator> validator = new Mock<ITriangleValidator>();
      _calculator = new TrianglePerimeterCalculator(validator.Object);
      _calculator.Calculate(_point1, _point2, _point3);
      validator.Verify(v => v.CheckIfTriangleCanBeBuilt(It.IsAny<Point3D>(), It.IsAny<Point3D>(), It.IsAny<Point3D>()),
        Times.Once());
    }
  }
}