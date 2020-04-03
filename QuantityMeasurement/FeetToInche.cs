using System;
using System.Collections.Generic;
using System.Text;

namespace QuantityMeasurement
{
    public class FeetToInche
    {
        public FeetToInche()
        {

        }
        public int Feet_to_inch_Conversion(int _feet)
        {
            int a = _feet * 12;

            return a;
        }
        public bool Feet_to_Inche_Equality( Feet _feet , Inches  inch)
        {
            var a = _feet.Get_Feet_Value() * 12;
            var b = inch.getInches();
            if (a== b)
                return true;
            return false;
        }
    }
}
