using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Celsius
    {
        double celsius;
        public Celsius(double _celsius)
        {
            this.celsius = _celsius;
        }
        /// <summary>
        /// It return the celsis value
        /// </summary>
        /// <returns></returns>
        public double Get_Celsius_Value()
        {
            return this.celsius;
        }
        /// <summary>
        /// Checking the equality of Celsisu value
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public bool Cheching_Equality_Of_Celsius_Value(Celsius celsius)
        {
            if (this.celsius == celsius.Get_Celsius_Value())
                return true;
            return false;
        }
    }
}
