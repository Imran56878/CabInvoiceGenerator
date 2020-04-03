using NUnit.Framework;
using QuantityMeasurement;
namespace NUnitQuantityMeasurementTest
{
    public class YardToFeetNUnitTest
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
        /// <summary>
        /// This mehod is checking that 1 yard is equal to 3 ft
        /// </summary>
        [Test]
        public void Cheking_Yard_Feet_Relation()
        {
            var feetValue = new Feet(3);
            var yardValue = new Yard(1);
            YardToFeet yardToFeet = new YardToFeet();
            Assert.AreEqual(yardToFeet.Converte_Yard_To_Feet(yardValue), feetValue.Get_Feet_Value());
        }
        /// <summary>
        /// This method is checking that 1ft is not equal to 1 yard
        /// </summary>
        [Test]
        public void Checking_ft_And_Yard_Unequality()
        {
            var feetValue = new Feet(1);
            var yardValue = new Yard(1);
            YardToFeet yardToFeet = new YardToFeet();
            Assert.IsFalse(yardToFeet.Checking_Yard_And_Feet_Value_Equality(feetValue, yardValue));
        }

    }
}
