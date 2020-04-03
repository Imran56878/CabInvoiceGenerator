using NUnit.Framework;
using QuantityMeasurement;

namespace NUnitQuantityMeasurementTest
{
   public class YardToInchesNUnitTest
    {
        [SetUp]
        public void Setup()
        {

        }
        /// <summary>
        /// This method for checking that 1 inch and 1 yard is not equal
        /// </summary>
        [Test]
        public void Checking_Inch__And_Yard_Equality()
        {
            Inches inches = new Inches(1);
            Yard yard = new Yard(1);
            YardToInches yardToInch = new YardToInches();
            Assert.IsFalse(yardToInch. Checking_Yard_And_Inch_Value_Equality( inches, yard));
        }

    }
}
