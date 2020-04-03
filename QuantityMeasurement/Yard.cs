using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
   public  class Yard
    {
        int yard;
        public Yard(int _yard)
        {
            this.yard = _yard;     
        }
        public int GetYard_value()
        {
         return this.yard;
        }
        /// <summary>
        /// Checking the equality of Celsisu value
        /// </summary>
        /// <param name="celsius"></param>
        /// <returns></returns>
        public bool Cheching_Equality_Of_Yard_Value(Yard yard)
        {
            if (this.yard == yard.GetYard_value())
            {
                return true;
            }
            return false;
        }
    }
}
