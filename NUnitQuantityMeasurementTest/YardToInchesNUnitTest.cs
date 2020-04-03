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
        /// <summary>
        /// This is checking that 1 Yard and 36 Inch equality
        /// </summary>
        [Test]
        public void Checking_Yard_And_Inch_Unequality()
        {
            Inches inches = new Inches(36);
            Yard yard = new Yard(1);
            YardToInches yardToInch = new YardToInches();
            Assert.IsTrue(yardToInch.Checking_Yard_And_Inch_Value_Equality(inches, yard));
        }

    }
}
