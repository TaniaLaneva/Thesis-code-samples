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
        [TestMethod]
        public void Given_Point3Ds_Equality_Checks()
        {
            var p = new Point3D(1, 1, 1);
            var r = new Point3D(2, 2, 2);
            var q = new Point3D(1, 1, 1);
            Assert.IsTrue(p.Equals(p));
            Assert.IsFalse(p.Equals(null));
            Assert.IsFalse(p.Equals("Point3D"));
            Assert.IsFalse(p.Equals(r));
            Assert.IsTrue(p.Equals(q));
            Assert.IsTrue(q.Equals(p));
        }

        [TestMethod]
        public void Given_Point3Ds_Difference_Checks()
        {
            var p = new Point3D(1, 1, 1);
            var r = new Point3D(0, 0, 0);
            var q = new Point3D(1, 1, 1);
            Assert.IsTrue((p - q).Equals(r));
            Assert.IsTrue((p - r).Equals(p));
            Assert.AreEqual(-1, (r - p).X);
            Assert.AreEqual(-1, (r - p).Y);
            Assert.AreEqual(-1, (r - p).Z);
        }


        [TestMethod]
        public void Given_Point3Ds_Distance_Checks()
        {
            var p = new Point3D(1, 1, 1);
            var r = new Point3D(0, 0, 0);

            Assert.AreEqual(0, p.GetDistanceToPoint(p));
            Assert.AreEqual(Math.Sqrt(3), p.GetDistanceToPoint(r));
        }
    }
}
