using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Samples.AdHocApproach;

namespace UnitTests.AdHocApproachTests
{
  [TestClass]
  public class PerimeterTests
  {
    private Perimeter _perimeter = new Perimeter();
    [TestMethod]
    public void CalculatePerimeter_Equal_Points_Returns_Null()
    {
      var result = _perimeter.CalculatePerimeter(new Tuple<double, double, double>(1, 1, 1),
        new Tuple<double, double, double>(1, 1, 1), new Tuple<double, double, double>(2, 2, 2));

      Assert.IsNull(result);
    }

    [TestMethod]
    public void CalculatePerimeter_Collinear_Points_Returns_Null()
    {
      var result = _perimeter.CalculatePerimeter(new Tuple<double, double, double>(4, 6, 8),
        new Tuple<double, double, double>(3, 5, 3), new Tuple<double, double, double>(2, 4, 2));

      Assert.IsNull(result);
    }

    [TestMethod]
    public void CalculatePerimeter_Valid_Points_Returns_Correct_Result()
    {
      var actual = _perimeter.CalculatePerimeter(new Tuple<double, double, double>(4, 6, 8),
        new Tuple<double, double, double>(3, 5, 3), new Tuple<double, double, double>(5, 4, 2));
      var expected = 14.04876640292266;
      Assert.AreEqual(expected, actual);
    }
  }
}