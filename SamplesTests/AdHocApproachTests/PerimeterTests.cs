using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Samples.AdHocApproach;
using Samples.CleanCodeApproach;

namespace UnitTests.AdHocApproachTests
{
  [TestClass]
  public class PerimeterTests
  {

    /// <summary>
    /// Given a triangle in a 2 dimensional space and only in the first quarter in the coordinate system
    /// 
    /// When we calculate the perimeter
    ///
    /// Then the result is correct
    /// </summary>
    [TestMethod]
    public void Should_Calculate_Perimeter_for_only_positive_points()
    {
      // Given
      var a = Tuple.Create(0.0, 0.0, 0.0);
      var b = Tuple.Create(3.0, 0.0, 0.0);
      var c = Tuple.Create(0.0, 4.0, 0.0);
      var calculator = new Perimeter();

      // When
      double? actual = calculator.CalculatePerimeter(a, b, c);

      // Then
      Assert.IsNotNull(actual);
      Assert.AreEqual(12.0, actual);
    }

    /// <summary>
    /// Given a triangle in a 2 dimensional space and only in all quarter in the coordinate system
    /// 
    /// When we calculate the perimeter
    ///
    /// Then the result is correct
    /// </summary>
    [TestMethod]
    public void Should_Calculate_Perimeter_for_different_quarter()
    {
      // Given
      var a = Tuple.Create(-1.0, -1.0, 0.0);
      var b = Tuple.Create(2.0, -1.0, 0.0);
      var c = Tuple.Create(-1.0, 3.0, 0.0);
      var calculator = new Perimeter();

      // When
      double? actual = calculator.CalculatePerimeter(a, b, c);

      // Then
      Assert.IsNotNull(actual);
      Assert.AreEqual(12.0, actual);
    }



    /// <summary>
    /// Given two points equal to each other
    ///
    /// When a perimeter is calcukalted 
    ///
    /// Then exception should thrown
    /// </summary>
    [TestMethod]
    public void Should_Throw_Exception_If_two_points_are_the_same()
    {
      // Given
      var a = Tuple.Create(0.0, 0.0, 0.0);
      var b = Tuple.Create(0.0, 0.0, 0.0);
      var c = Tuple.Create(0.0, 4.0, 0.0);
      var calculator = new Perimeter();

      // When
      double? actual = calculator.CalculatePerimeter(a, b, c);

      // Then
      Assert.IsNull(actual);
    }
  }
}
