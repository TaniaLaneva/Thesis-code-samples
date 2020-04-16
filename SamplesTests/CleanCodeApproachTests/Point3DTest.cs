using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Samples.CleanCodeApproach;

namespace UnitTests.CleanCodeApproachTests
{
  [TestClass]
  public class Point3DTest
  {
    /// <summary>
    /// Given a point
    ///
    /// When we retrieve the coordinate one by one
    ///
    /// Then the coordinates matches what we gave
    ///
    /// </summary>
    [TestMethod]
    public void Should_Match_Coordinates()
    {
      // Given
      double x = 1.0;
      double y = -1.0;
      double z = 0.5;
      var point = new Point3D(x, y, z);

      // Then
      Assert.AreEqual(x, point.X);
      Assert.AreEqual(y, point.Y);
      Assert.AreEqual(z, point.Z);
    }

    /// <summary>
    /// Given two identical points
    ///
    /// When we retrieve the hashcode
    ///
    /// Then they should be the same
    ///
    /// </summary>
    [TestMethod]
    public void Should_Match_Hashes()
    {
      // Given
      Point3D a = new Point3D(1.0, -1.0, 0.5);
      Point3D b = new Point3D(1.0, -1.0, 0.5);

      // Then
      Assert.AreEqual(a.GetHashCode(), b.GetHashCode());
    }

    /// <summary>
    /// Given two points assign to the same coordinate
    /// And  a third one which is assign to a different coordinate
    ///
    /// When we calculate the distance between them
    ///
    /// Then the two point is equal to each other
    ///
    /// </summary>
    [TestMethod]
    public void Should_Check_If_Coordinates_are_the_same()
    {
      // Given 
      Point3D a = new Point3D(1.0, 2.0, 3.0);
      Point3D b = new Point3D(1.0, 2.0, 3.0);
      Point3D c = new Point3D(2.0, 2.0, 3.0);

      // When
      bool aEqualsToB = a.Equals(b);
      bool aEqualsToC = a.Equals(c);

      // Then
      Assert.IsTrue(aEqualsToB);
      Assert.IsFalse(aEqualsToC);
    }

    /// <summary>
    /// Given two points with a distance of 10 units
    ///
    /// When the distance is calculated between the two points
    ///
    /// Then the actual result is 10
    ///
    /// </summary>
    [TestMethod]
    public void Should_Calculate_The_Distance()
    {
      // Given 
      Point3D a = new Point3D(-10.0, 0.0, 0.0);
      Point3D b = new Point3D(10.0, 0.0, 0.0);
      Point3D c = new Point3D(0.0, -10.0, 0.0);
      Point3D d = new Point3D(0.0, 10.0, 0.0);
      Point3D e = new Point3D(0.0, 0.0, -10.0);
      Point3D f = new Point3D(0.0, 0.0, 10.0);

      // When
      double ab = a.GetDistanceToPoint(b);
      double cd = c.GetDistanceToPoint(d);
      double ef = e.GetDistanceToPoint(f);

      // Then
      const double expected = 20.0;
      Assert.AreEqual(expected, ab);
      Assert.AreEqual(expected, cd);
      Assert.AreEqual(expected, ef);

    }

  }
}
