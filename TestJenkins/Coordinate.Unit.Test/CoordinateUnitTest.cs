using NUnit.Framework;

namespace Coordinate.Unit.Test
{
    [TestFixture]
    public class CoordinateUnitTest
    {
        private ICoordinateTest _uut;

        [SetUp]
        public void Setup()
        {
            _uut = new CoordinateTest(4,5);
        }

        [Test]
        public void GetY_return5()
        {
            Assert.That(_uut.y, Is.EqualTo(5));
        }
    }
}