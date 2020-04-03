using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class CelsiusToFahrenheit
    {
        /// <summary>
        /// it convert the celsius value 
        /// into fahrenheit value
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public double Celsius_to_fahrenheit_conversion(Celsius celsius)
        {
            return celsius.Get_Celsius_Value();

        }
        /// <summary>
        /// this method is for checking the equality of Celsius and fahranheit value
        /// </summary>
        /// <param name="celsius"></param>
        /// <param name="fahranheit"></param>
        /// <returns></returns>
        public bool Checking_Equality_Of_Celsius_And_Fahrenheit_Value(Celsius celsius, Fahrenheit fahranheit)
        {
            var fahranheitValue = (celsius.Get_Celsius_Value() * 9 / 5) + 32;
            if (fahranheit.Get_Fahrenheit_Value() == fahranheitValue)
            {
                return true;
            }
            return false;
        }
    }
}
