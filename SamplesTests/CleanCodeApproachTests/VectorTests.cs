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
    [TestMethod]
    public void Parallel_Vectors_Return_True()
    {
      var vector1 = new Vector(new Point3D(1, 1, 1));
      var vector2 = new Vector(new Point3D(2, 2, 2));
      Assert.IsTrue(vector1.IsParallelToVector(vector2));
    }

    [TestMethod]
    public void Parallel_Vectors_Return_False()
    {
      var vector1 = new Vector(new Point3D(1, 1, 1));
      var vector2 = new Vector(new Point3D(2, 2, 20));
      Assert.IsTrue(vector1.IsParallelToVector(vector2));
    }

    [TestMethod]
    public void Parallel_Vectors_Return_True_Both_Contain_Zeros()
    {
      var vector1 = new Vector(new Point3D(1, 1, 0));
      var vector2 = new Vector(new Point3D(2, 2, 0));
      Assert.IsTrue(vector1.IsParallelToVector(vector2));
    }

    [TestMethod]
    public void Zero_Vectors_Return_False_Not_Giving_Exceptions()
    {
      var vector1 = new Vector(new Point3D(0, 0, 0));
      var vector2 = new Vector(new Point3D(0, 0, 0));
      Assert.IsFalse(vector1.IsParallelToVector(vector2));
    }

    [TestMethod]
    public void Zero_Vector_Return_False_Not_Giving_Exceptions()
    {
      var vector1 = new Vector(new Point3D(1, 2, 3));
      var vector2 = new Vector(new Point3D(0, 0, 0));
      Assert.IsFalse(vector1.IsParallelToVector(vector2));
    }
  }
}