using NUnit.Framework;
using Samples.AdHocApproach;
using System;

namespace UnitTests.AdHocApproachTests
{

  public class PerimeterTests
  {
    [Test]
    public void CalculatePerimeter_Result_For_Three_Valid_Triangle_Coordinates_Is_Correct()
    {
      var perimeterCalculator = new Perimeter();

      var point1 = new Tuple<double, double, double>(6, 0, 0);
      var point2 = new Tuple<double, double, double>(0, 6, 0);
      var point3 = new Tuple<double, double, double>(0, 0, 0);

      var result = perimeterCalculator.CalculatePerimeter(point1, point2, point3);

      Assert.AreEqual(20.4852, result, 0.001);
    }

    //[Test]
    //public void CalculatePerimeter_For_Triangle_Coordinates_On_A_Same_Line_Returns_Null()
    //{
    //  var perimeterCalculator = new Perimeter();

    //  var point1 = new Tuple<double, double, double>(1, 0, 0);
    //  var point2 = new Tuple<double, double, double>(2, 0, 0);
    //  var point3 = new Tuple<double, double, double>(3, 0, 0);

    //  var result = perimeterCalculator.CalculatePerimeter(point1, point2, point3);

    //  Assert.IsNull(result);
    //}

    [Test]
    public void CalculatePerimeter_With_Two_Same_Coordinates_Returns_Null()
    {
      var perimeterCalculator = new Perimeter();

      var point1 = new Tuple<double, double, double>(1, 0, 0);
      var point2 = new Tuple<double, double, double>(1, 0, 0);
      var point3 = new Tuple<double, double, double>(0, 0, 0);

      var result = perimeterCalculator.CalculatePerimeter(point1, point2, point3);

      Assert.IsNull(result);
    }
  }
}
