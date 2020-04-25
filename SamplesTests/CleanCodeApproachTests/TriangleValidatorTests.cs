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
        private TriangleValidator _sut;
        
        [TestInitialize]
        public void Setup()
        {
            _sut = new TriangleValidator();
        }

        [TestMethod]
        public void Given_Three_Points_That_Are_Incolinear_Pass()
        {
            var a = new Point3D(1, 0, 0);
            var b = new Point3D(0, 0, 1);
            var c = new Point3D(0, 1, 0);

            _sut.CheckIfTriangleCanBeBuilt(a, b, c);
            // assert line above did not throw unhandled exception
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Given_Two_Points_That_Are_The_Same_Throws_Exception()
        {
            var a = new Point3D(1, 0, 0);
            var b = new Point3D(1, 0, 0);
            var c = new Point3D(0, 1, 0);

            var exception = Assert.ThrowsException<ArgumentException>(() => _sut.CheckIfTriangleCanBeBuilt(a, b, c));
            Assert.AreEqual("Can not use same points to calculate triangle perimeter (Parameter 'TriangleValidator')", exception.Message);
        }

        [TestMethod]
        public void Given_Three_Points_That_Are_The_Colinear_Throws_Exception()
        {
            var a = new Point3D(1, 0, 0);
            var b = new Point3D(2, 0, 0);
            var c = new Point3D(4, 0, 0);
            var c1 = new Point3D(-1, 0, 0);

            var exception = Assert.ThrowsException<ArgumentException>(() => _sut.CheckIfTriangleCanBeBuilt(a, b, c));
            Assert.AreEqual("Can not use collinear points to calculate triangle perimeter (Parameter 'TriangleValidator')", exception.Message);

            // bug.
            exception = Assert.ThrowsException<ArgumentException>(() => _sut.CheckIfTriangleCanBeBuilt(a, b, c1));
            Assert.AreEqual("Can not use collinear points to calculate triangle perimeter (Parameter 'TriangleValidator')", exception.Message);


        }
    }
}
