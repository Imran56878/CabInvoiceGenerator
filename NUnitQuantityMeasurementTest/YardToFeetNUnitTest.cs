using NUnit.Framework;
using QuantityMeasurement;
namespace NUnitQuantityMeasurementTest
{
   public  class YardToFeetNUnitTest
    {
        [SetUp]
        public void Setup()
        {

        }
        /// <summary>
        /// This Method converting yard to feet value
        /// </summary>
        [Test]
        public void Converting_Yard_To_Feet_Value()
        {
            Yard yard = new Yard(1);
            YardToFeet yardToFeet = new YardToFeet();
            var feetValue = yardToFeet.Converte_Yard_To_Feet(yard);
            Assert.AreEqual(feetValue, 3);
        }


    }
}
