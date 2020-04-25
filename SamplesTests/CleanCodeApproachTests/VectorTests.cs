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
        public void Given_Two_Converging_Vectors_Return_Not_Parallel()
        {
            var v = new Vector(new Point3D(1, 1, 1));
            var w = new Vector(new Point3D(0, 1, 1));
            Assert.IsFalse(v.IsParallelToVector(w));
        }

        [TestMethod]
        public void Given_Two_Parallel_Vectors_Return_Parallel()
        {
            var v = new Vector(new Point3D(1, 1, 1));
            var w = new Vector(new Point3D(2, 2, 2));
            Assert.IsTrue(v.IsParallelToVector(w));
        }
    }
}
