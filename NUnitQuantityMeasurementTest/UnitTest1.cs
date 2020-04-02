using NUnit.Framework;
using QuantityMeasurement;
namespace NUnitQuantityMeasurementTest
{
    public class Tests
    {
        //Feet feet = new Feet(0);
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FeetValueTest()
        {
            Feet feet = new Feet(0);
            Assert.AreEqual(true,feet.ConvertedFeetValue( feet));
        }
        [Test]
        public void NullReference_Value_Equals()
        {
            Feet feet = new Feet(1);
            Assert.IsFalse(feet.Equals(null));
        }
    }
}