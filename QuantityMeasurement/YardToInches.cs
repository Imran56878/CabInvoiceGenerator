using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
  public   class YardToInches
    {
        /// <summary>
        /// it convert the yard to feet 
        /// </summary>
        /// <param name="yard"></param>
        /// <returns></returns>

        public int Converte_Yard_To_Inches(Yard yard)
        {
            var yardToFeet = yard.GetYard_value() * 3*12;
            var feetValue = new Feet(yardToFeet);
            return feetValue.Get_Feet_Value();
        }
        /// <summary>
        /// This method is checking the equality of inches and yard value
        /// </summary>
        /// <param name="feetValue"></param>
        /// <param name="yardValue"></param>
        /// <returns></returns>
        public bool Checking_Yard_And_Feet_Value_Equality(Inches inch, Yard yardValue)
        {
            var value = yardValue.GetYard_value() * 3*12;
            if (inch.getInches() == value)
                return true;
            return false;
        }
    }
}
