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
         /// <summary>
         /// It check the 
         /// feet value
         /// </summary>
        [Test]
        public void FeetValueTest()
        {
            Feet feet = new Feet(0);
            Assert.AreEqual(true,feet.ConvertedFeetValue( feet));
        }
        /// <summary>
        /// Null reference 
        /// </summary>
        [Test]
        public void NullReference_Value_Equals()
        {
            Feet feet = new Feet(1);
            Assert.IsFalse(feet.Equals(null));
        }
        /// <summary>
        /// reference check
        /// </summary>
        [Test]
        public void Reference_Type_Feet_Value_Equal()
        {
            Feet feet = new Feet(2);
            Assert.IsTrue(feet.ConvertedFeetValue(feet));
        }
        [Test]
        public void Feet_To_Inch_Converter()
        {
            FeetToInche feet_to_inch = new FeetToInche();
            var a= feet_to_inch.Feet_to_inch_Conversion(5);
            Assert.AreEqual(60,a);
        }
        /// <summary>
        /// This method for checking 1ft and 2ft is not equal
        /// </summary>
        [Test]
        public void Checking_Diffrent_Feet_Value()
        {
            FeetToInche feet_to_inch = new FeetToInche();
            var val1 = new Feet(1);
            var val2 = new Feet(2);
            Assert.AreEqual(feet_to_inch.Feet_to_inch_Conversion(1), feet_to_inch.Feet_to_inch_Conversion(2));
        }

    }
}