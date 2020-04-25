using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Samples.AdHocApproach;

namespace UnitTests.AdHocApproachTests
{
    [TestClass]
    public class PerimeterTests
    {
        private Perimeter _sut;

        [TestInitialize]
        public void Setup()
        {
            _sut = new Perimeter();
        }

        [TestMethod]
        public void Given_Equilateral_Triangle_Return_Perimeter()
        {
            // each side is Sqrt(2) long
            var result = _sut.CalculatePerimeter(Tuple.Create(1d,0d,0d), Tuple.Create(0d,1d,0d), Tuple.Create(0d,0d,1d));
            var expected = Math.Sqrt(2) * 3;
            Assert.IsNotNull(result);
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Given_Random_Valid_Triangle_Return_Perimeter()
        {
            var r = new Random();
            // each side is Sqrt(2) long
            var result = _sut.CalculatePerimeter(Tuple.Create(r.NextDouble(), r.NextDouble(), 0d), 
                Tuple.Create(0d, r.NextDouble(), r.NextDouble()), 
                Tuple.Create(r.NextDouble(), 0d, r.NextDouble()));
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Given_Two_Points_That_Are_The_Same_Return_Null()
        {
            var result = _sut.CalculatePerimeter(Tuple.Create(1d, 0d, 0d), Tuple.Create(1d, 0d, 0d), Tuple.Create(0d, 0d, 1d));
            Assert.IsNull(result);
        }

        [TestMethod]
        public void Given_Colinear_Points_Return_Null()
        {
            var result = _sut.CalculatePerimeter(Tuple.Create(1d, 0d, 0d), Tuple.Create(2d, 0d, 0d), Tuple.Create(-1d, 0d, 0d));
            Assert.IsNull(result);
        }
    }
}
