namespace KalkulatorSzkolny
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Kalkulator szkolny ===");

            Console.WriteLine($"2 + 3 = {Kalkulator.Dodaj(2, 3)}");
            Console.WriteLine($"10 - 4 = {Kalkulator.Odejmij(10, 4)}");
            Console.WriteLine($"5 * 6 = {Kalkulator.Pomnoz(5, 6)}");
            Console.WriteLine($"20 / 4 = {Kalkulator.Podziel(20, 4)}");

            Console.WriteLine();

            Console.WriteLine($"Czy 10 jest parzyste? {Liczby.CzyParzysta(10)}");
            Console.WriteLine($"Czy 7 jest parzyste? {Liczby.CzyParzysta(7)}");
        }
    }
}