using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class YardToFeet
    {
        /// <summary>
        /// it convert the yard to feet 
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>
        public int Converte_Yard_To_Feet(Yard yard)
        {
            var yardToFeet = yard.GetYard_value() * 3;
            var feetValue = new Feet(yardToFeet);
            return feetValue.Get_Feet_Value();
        }

        /// <summary>
        /// This method is checking the equality of feet and yard value
        /// </summary>
        /// <param name="feetValue"></param>
        /// <param name="yardValue"></param>
        /// <returns></returns>
        public bool Checking_Yard_And_Feet_Value_Equality(Feet feetValue, Yard yardValue)
        {
            var value = yardValue.GetYard_value() * 3;
            if (feetValue.Get_Feet_Value() == value)
                return true;
            return false;
        }
    }
}
