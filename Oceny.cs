using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorSzkolny
{
    public static class Oceny

    {
        public static string Opisz(int ocena)
        {
            if (ocena < 1 || ocena > 6)
            {
                return "ocena nieprawidlowa";
            }
            if (ocena <= 2)
            {
                return "ocena niska";
            }
            if (ocena <= 4)
            {
                return "ocena srednia";
            }
            return "ocena wysoka";
        }
    }
}
