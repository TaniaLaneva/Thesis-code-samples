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
    private Point3D _point1 = new Point3D(1, 2, 3);
    private Point3D _point2 = new Point3D(1, 2, 3);
    private Point3D _point3 = new Point3D(10, -2, 13);

    [TestMethod]
    public void Calculate_Distance_Between_Two_Equal_Points()
    {
      var actual = _point1.GetDistanceToPoint(_point2);
      var expected = 0;
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Calculate_Distance_Between_Two_Not_Equal_Points()
    {
      var actual = _point1.GetDistanceToPoint(_point3);
      var expected = 14.035668847618199;
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void Check_Minus_Operator_Between_Equal_Points_X_Coordinate_Is_Correct()
    {
      var actual = (_point3 - _point1).X;
      Assert.AreEqual(9, actual);
    }

    [TestMethod]
    public void Check_Minus_Operator_Between_Equal_Points_Y_Coordinate_Is_Correct()
    {
      var actual = (_point3 - _point1).Y;
      Assert.AreEqual(-4, actual);
    }

    [TestMethod]
    public void Check_Minus_Operator_Between_Equal_Points_Z_Coordinate_Is_Correct()
    {
      var actual = (_point3 - _point1).Z;
      Assert.AreEqual(10, actual);
    }

    [TestMethod]
    public void Check_Points_Are_Equals()
    {
      Assert.IsTrue(_point1.Equals(new Point3D(1,2,3)));
    }

    [TestMethod]
    public void Check_Point_Is_Not_Equal_To_Null()
    {
      Assert.IsFalse(_point1.Equals(null));
    }

    [TestMethod]
    public void Check_Point_Is_Not_Equal_To_Another_Object()
    {
      Assert.IsFalse(_point1.Equals(new Vector(_point1)));
    }

    [TestMethod]
    public void Check_Point_Is_Not_Equal_To_Another_Point()
    {
      Assert.IsFalse(_point1.Equals(_point3));
    }
  }
}