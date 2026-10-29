using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorSzkolny
{
    public static class WalidatorZestawow
    {
        public static bool CzyPoprawnaLiczba(int liczbaZestawow)
        {
            return liczbaZestawow >= 1 && liczbaZestawow <= 100;
        }
    }
}
