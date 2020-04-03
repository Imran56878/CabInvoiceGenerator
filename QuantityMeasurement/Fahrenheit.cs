using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Fahrenheit
    {
        double fahrenheit;
        public Fahrenheit(double _fahrenheit)
        {
            this.fahrenheit = _fahrenheit;
        }
        /// <summary>
        /// it return the fahrenheit value
        /// </summary>
        /// <returns></returns>
        public double Get_Fahrenheit_Value()
        {
            return this.fahrenheit;
        }

    }
}
