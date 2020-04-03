using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class Gram
    {
        int gram;
        public Gram(int _gram)
        {
            this.gram = _gram;
        }
        public int Get_Gram_Value()
        {
            return this.gram;
        }
        /// <summary>
        /// This method is checking the gram equality
        /// </summary>
        /// <param name="gram"></param>
        /// <returns></returns>
        public bool Checking_Equality_Of_Grams(Gram gram)
        {
            if (this.gram == gram.Get_Gram_Value())
                return true;
            return false;
        }
    }
}
