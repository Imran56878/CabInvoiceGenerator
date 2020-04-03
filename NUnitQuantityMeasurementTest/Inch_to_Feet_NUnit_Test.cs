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
        /*[Test]
        public void Test()
        {
            Feet feet = new Feet(1);
            Assert.IsTrue(inchToFeet.Inche_to_Feet_Equality(feet, inch));
        }*/

    }
}
