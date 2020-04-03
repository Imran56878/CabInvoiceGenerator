using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
   public  class Kilogram
    {
        int kilogram;
        public Kilogram(int _kilogram)
        {
            this.kilogram = _kilogram;
        }
        public int Get_kilogram_value()
        {

            return this.kilogram;
        }
        /// <summary>
        /// This method is checking the Kilgram equality
        /// </summary>
        /// <param name="kgram"></param>
        /// <returns></returns>
        public bool Checking_Equality_Of_Kilo_Grams(Kilogram kgram)
        {
            if (this.kilogram == kgram.Get_kilogram_value())
                return true;
            return false;
        }
    }
}
