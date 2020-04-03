using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
   public  class InchesToFeetConversion
    {
        int inch;
        /*public InchesToFeetConversion(int _inch)
        {
            this.inch = _inch;
        }*/
        /// <summary>
        /// It convert the inches into feet
        /// 
        /// </summary>
        /// <param name="inch"></param>
        /// <returns></returns>
        public double  Inch_to_Feet_Conversion(Inches inch)
        {
            var a = inch.getInches();
            return (a/12);
        }
        /// <summary>
        /// It check the equality
        /// between feet and inches parameter
        /// value
        /// </summary>
        /// <param name="_feet"></param>
        /// <param name="inch"></param>
        /// <returns></returns>
        public bool Inche_to_Feet_Equality(Feet _feet, Inches inch)
        {
            var a = _feet.Get_Feet_Value() * 12;
            var b = inch.getInches();
            if (a == b)
                return true;
            return false;
        }

    }
}
