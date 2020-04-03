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
            Gram gram1 = new Gram(1);
            var gram2 = new Gram(1);
            Assert.IsTrue(gram1.Get_Gram_Value().Equals(gram2.Get_Gram_Value()));

        }
        /// <summary>
        /// This Test case is checking that 1gram is equal to 2gram
        /// </summary>
        [Test]
        public void Checking_Equality_Of_Different_Grams_Value()
        {
            var gram1 = new Gram(1);
            var gram2 = new Gram(2);
            Assert.IsFalse(gram1.Checking_Equality_Of_Grams(gram2));
        }
    }
}
