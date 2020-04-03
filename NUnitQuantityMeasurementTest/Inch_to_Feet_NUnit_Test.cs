﻿using NUnit.Framework;
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

    }
}