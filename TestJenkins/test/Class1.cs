using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Coordinate;
using NUnit.Framework;

namespace test
{
    [TestFixture]
    public class test
    {
        private ICoordinateTest _coordinate;
        [SetUp]
        public void Setup()
        {
            _coordinate = new CoordinateTest(5,6);
        }

        [Test]
        public void Test()
        {
            Assert.That(_coordinate.y, Is.EqualTo(6));
        }
    }
}
