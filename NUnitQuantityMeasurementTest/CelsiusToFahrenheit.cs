﻿using NUnit.Framework;
using QuantityMeasurement;

namespace NUnitQuantityMeasurementTest
{
    public class CelsiusToFahrenheitNUnitTest
    {
        [SetUp]
        public void Setup()
        {

        }
        /// <summary>
        /// Checking the equality of two celsius value
        /// </summary>
        [Test]
        public void Checking_Equality_Of_Celsius_Value()
        {
            Celsius celsius = new Celsius(1);
            Celsius celsius1 = new Celsius(1);
            Assert.IsTrue(celsius.Cheching_Equality_Of_Celsius_Value(celsius1));
        }
        /// <summary>
        /// This method is checking the value of Celsius and fahranheit
        /// </summary>
        [Test]
        public void Checking_Equality_Of_Celsius_And_Fahranheit_Value()
        {
            Celsius celsius = new Celsius(1);
            Fahrenheit fahrenheit = new Fahrenheit(33.8);
            CelsiusToFahrenheit celsiusToFahrenheit = new CelsiusToFahrenheit();
            Assert.IsTrue(celsiusToFahrenheit.Checking_Equality_Of_Celsius_And_Fahrenheit_Value(celsius, fahrenheit));
        }
        /// <summary>
        /// Checking the equality of two celsius value
        /// </summary>
        [Test]
        public void Checking_Equality_Relation_Of_Diffrent_Celsius_Value()
        {
            Celsius celsius = new Celsius(1);
            Celsius celsius1 = new Celsius(2);
            Assert.IsFalse(celsius.Cheching_Equality_Of_Celsius_Value(celsius1));
        }
        /// <summary>
        /// This method is checking the value of Celsius and fahranheit
        /// </summary>
        [Test]
        public void Checking_Equality_Of_Celsius_And_Fahranheit_Value()
        {
            Celsius celsius = new Celsius(1);
            Fahrenheit fahranheit = new Fahrenheit(50);
            CelsiusToFahrenheit celsiusToFahrenheit = new CelsiusToFahrenheit();
            Assert.IsFalse(celsiusToFahrenheit.Celsius_to_fahrenheit_conversion(celsius).Equals(celsius.Get_Celsius_Value()) );
        }
    }
}
