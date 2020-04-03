using NUnit.Framework;
using QuantityMeasurement;

namespace NUnitQuantityMeasurementTest
{
    public class CelsiusToFahrenheitNUnitTest
    {
        [SetUp]
        public void Setup()
        {

        }
        /// <summary>
        /// Checking the equality of two celsius value
        /// </summary>
        [Test]
        public void Checking_Equality_Of_Celsius_Value()
        {
            Celsius celsius = new Celsius(1);
            Celsius celsius1 = new Celsius(1);
            Assert.IsTrue(celsius.Cheching_Equality_Of_Celsius_Value(celsius1));
        }
    }
}
