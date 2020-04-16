using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Samples.CleanCodeApproach;

namespace UnitTests.CleanCodeApproachTests
{
  [TestClass]
  public class TriangleValidatorTests
  {
    /// <summary>
    /// Given three points for a triangle
    ///
    /// When we check if the triangle can be built with the three given points
    ///
    /// Then no exception is thrown
    ///
    /// </summary>
    [TestMethod]
    public void Should_Check_Triangle_Can_Be_Built()
    {
      // Given 
      var triangleValidator = new TriangleValidator();
      Point3D a = new Point3D(0.0, 0.0, 0.0);
      Point3D b = new Point3D(3.0, 0.0, 0.0);
      Point3D c = new Point3D(0.0, 4.0, 0.0);

      // When
      triangleValidator.CheckIfTriangleCanBeBuilt(a, b, c);
    }

    /// <summary>
    /// Given three points for a 
    ///
    /// When we check if the triangle can be built with the three given points
    ///
    /// Then exception is thrown
    ///
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Should_Throw_Exception_Due_To_Identical_Points()
    {
      // Given 
      var triangleValidator = new TriangleValidator();
      Point3D a = new Point3D(0.0, 0.0, 0.0);
      Point3D b = new Point3D(0.0, 0.0, 0.0);
      Point3D c = new Point3D(0.0, 4.0, 0.0);

      // When
      triangleValidator.CheckIfTriangleCanBeBuilt(a, b, c);
    }

    /// <summary>
    /// Given three points for a 
    ///
    /// When we check if the triangle can be built with the three given points
    ///
    /// Then exception is thrown
    ///
    /// </summary>
    [TestMethod]
    [ExpectedException(typeof(ArgumentException))]
    public void Should_Throw_Exception_Due_To_Parallel_Vectors()
    {
      // Given 
      var triangleValidator = new TriangleValidator();
      Point3D a = new Point3D(0.0, 0.0, 0.0);
      Point3D b = new Point3D(4.0, 2.0, 4.0);
      Point3D c = new Point3D(2.0, 1.0, 2.0);

      // When
      triangleValidator.CheckIfTriangleCanBeBuilt(a, b, c);
    }
  }
}
