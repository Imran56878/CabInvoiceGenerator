using NUnit.Framework;
using QuantityMeasurement;
namespace NUnitQuantityMeasurementTest

{
    public class Inch_to_Feet_NUnit_Test
    {
        [SetUp]
        public void Setup()
        {

        }
        /// <summary>
        /// This method converting inch value into Feet value
        /// </summary>
        [Test]
        public void Converting_Inch_To_Feet()
        {
           
            Inches inch = new Inches(12);
            InchesToFeetConversion  inchToFeet = new InchesToFeetConversion();
            var feetValue = inchToFeet.Inch_to_Feet_Conversion (inch);
           Assert.AreEqual(1,feetValue);
        }
        /// <summary>
        /// Checking Null Value and it return false if value is null
        /// </summary>
        [Test]
        public void Checking_NullRefrence_Value()
        {
            Inches inches = new Inches(12);
            Assert.IsFalse(inches.Equals(null));
        }
        /// <summary>
        /// Method for Checking feet Reference value
        /// </summary>
        [Test]
        public void Reference_Type_Inch_Value_Equal()
        {
            Inches inch = new Inches(2);
            Assert.IsTrue(inch.ConvertedInchValue(inch));
        }
        /// <summary>
        /// Method for Checking the value of  0 inch  and 0 inch
        /// </summary>
        [Test]
        public void Checking_Values_Equality()
        {
            Inches inch = new Inches(0);
            Inches inch1 = new Inches(0);
            Assert.AreEqual(inch.getInches(),inch1.getInches());
        }
        /// <summary>
        /// This method for checking 1 inch and 2 inch is not equal
        /// </summary>
        [Test]
        public void Checking_Diffrent_Feet_Value()
        {
            Inches inch = new Inches(1);
            Inches inch1 = new Inches(2);
            Assert.AreNotEqual(inch.getInches(), inch1.getInches());
        }

    }
}
