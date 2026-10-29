using System;
using System.Collections.Generic;
using System.Text;

namespace KalkulatorSzkolny;

public static class Kalkulator
{
    public static int Dodaj(int a, int b)
    {
        return a + b;
    }

    public static int Odejmij(int a, int b)
    {
        return a - b;
    }

    public static int Pomnoz(int a, int b)
    {
        return a * b;
    }

    public static int Podziel(int a, int b)
    {
        if (b == 0)
            throw new ArgumentException("Nie można dzielić przez zero.");

        return a / b;
    }
}