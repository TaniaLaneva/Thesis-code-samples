using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Samples.CleanCodeApproach;

namespace UnitTests.CleanCodeApproachTests
{
  [TestClass]
  public class VectorTests
  {
    /// <summary>
    /// Given two vector (a,b) parallel to each other
    /// And a third vector (c) which is not
    ///
    /// When we check if and b are parallel and if a and c are parallel
    ///
    /// Then a,b are parallel and a and c are not parallel
    ///
    /// </summary>
    [TestMethod]
    public void Should_Check_If_Two_Vectors_Are_Parallel()
    {
      // Given 
      var a = new Vector(new Point3D(0.0, 1.0, 0.0));
      var b = new Vector(new Point3D(0.0, 10.0, 0.0));
      var c = new Vector(new Point3D(5.0, 10.0, 0.0));

      // When
      var aParallelTob = a.IsParallelToVector(b);
      var aParallelToc = a.IsParallelToVector(c);

      // Then
      Assert.IsTrue(aParallelTob);
      Assert.IsFalse(aParallelToc);
    }
  }
}
