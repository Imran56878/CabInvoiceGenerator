using NUnit.Framework;
using QuantityMeasurement;

namespace NUnitQuantityMeasurementTest
{
     public class KilogramToGramNUnitTestCases
    {
        [SetUp]
        public void Setup()
        {

        }
        /// <summary>
        /// This Test case is checking that 1gram is equal to 1gram
        /// </summary>
        [Test]
        public void Checking_Equality_Of_Same_Gram_Value()
        {
           Gram  gram1= new Gram(1);
            var gram2 = new Gram(1);
            Assert.IsTrue(gram1.Get_Gram_Value().Equals(gram2.Get_Gram_Value()));

        }
    }
}
