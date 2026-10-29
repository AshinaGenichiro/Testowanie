using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorSzkolny
{
    public static class Geometria
    {
        public static int PoleProstokata(int bokA, int bokB)
        {
            if (bokA <= 0 || bokB <= 0)
            {
                throw new ArgumentException("Boki muszą być dodatnie.");
            }
            return bokA * bokB;
        }
    }
}
