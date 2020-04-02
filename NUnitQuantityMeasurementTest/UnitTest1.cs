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

    }
}