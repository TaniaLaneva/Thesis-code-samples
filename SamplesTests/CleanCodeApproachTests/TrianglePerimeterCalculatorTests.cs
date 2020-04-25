using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Samples.CleanCodeApproach;

namespace UnitTests.CleanCodeApproachTests
{
    public class MockTriangleValidator : ITriangleValidator
    {
        public void CheckIfTriangleCanBeBuilt(Point3D point1, Point3D point2, Point3D point3)
        {
            // do nothing.
        }
    }

    [TestClass]
    public class TrianglePerimeterCalculatorTests
    {
        private TrianglePerimeterCalculator _sut;

        [TestInitialize]
        public void Setup()
        {
            _sut = new TrianglePerimeterCalculator(new MockTriangleValidator());
        }

        [TestMethod]
        public void Given_Three_Points_Return_Perimeter()
        {
            var a = new Point3D(1, 0, 0);
            var b = new Point3D(0, 1, 0);
            var c = new Point3D(0, 0, 1);
            var expected = Math.Sqrt(2) * 3;

            var result = _sut.Calculate(a,b,c);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void Given_Three_Negative_Points_Return_Perimeter()
        {
            var a = new Point3D(-1, 0, 0);
            var b = new Point3D(0, -1, 0);
            var c = new Point3D(0, 0, -1);
            var expected = Math.Sqrt(2) * 3;

            var result = _sut.Calculate(a, b, c);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, expected);
        }

        [TestMethod]
        public void Given_Three_Maxvalue_Points_Return_Infinity()
        {
            var a = new Point3D(double.MaxValue, 0, 0);
            var b = new Point3D(0, double.MinValue, 0);
            var c = new Point3D(0, 0, double.MaxValue);

            var result = _sut.Calculate(a, b, c);
            Assert.IsNotNull(result);
            Assert.AreEqual(result, double.PositiveInfinity);
        }
    }
}
