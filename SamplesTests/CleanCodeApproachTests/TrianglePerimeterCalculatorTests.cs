using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Samples.CleanCodeApproach;

namespace UnitTests.CleanCodeApproachTests
{
  [TestClass]
  public class TrianglePerimeterCalculatorTests
  {
    /// <summary>
    /// Given three points for a triangle 
    ///
    /// When the perimeter is calculated
    ///
    /// Then the results should be correct
    ///
    /// </summary>
    [TestMethod]
    public void Should_Calculate_Perimeter()
    {
      // Given 
      var a = new Point3D(-1.0, -1.0, 0.0);
      var b = new Point3D(2.0, -1.0, 0.0);
      var c = new Point3D(-1.0, 3.0, 0.0);
      var calculator = new TrianglePerimeterCalculator(new TriangleValidator());

      // When
      double perimeter = calculator.Calculate(a, b, c);

      // Then
      Assert.AreEqual(12.0, perimeter);

    }


  }
}
