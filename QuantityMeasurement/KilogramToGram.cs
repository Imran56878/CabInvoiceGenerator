using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
   public class KilogramToGram
    {
        /// <summary>
        /// it conert kilogram  to grams
        /// </summary>
        /// <param name="kgram"></param>
        /// <returns></returns>
        public int KiloGram_to_gram_Conversion(Kilogram kgram)
        {
            var a = kgram.Get_kilogram_value() * 1000;
            return a;
        }
        /// <summary>
        /// Checking the equality of Kilogram and gram
        /// </summary>
        /// <param name="kilogram"></param>
        /// <param name="gram"></param>
        /// <returns></returns>
        public bool Checking_Equality_Kilogram_To_Gram(Kilogram kilogram, Gram gram)
        {
            var value = kilogram.Get_kilogram_value() * 1000;
            if (gram.Get_Gram_Value() == value)
            {
                return true;
            }
            return false;
        }
    }
}
