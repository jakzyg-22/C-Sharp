namespace Zadanie2__26._03;

class Program
{
    static void Main(string[] args)
    {
        Dzien dzien = new Dzien(26, Miesiace.Marzec, PoryRoku.Wiosna);
        Console.WriteLine($"{dzien.Wyswietl}");
    }
}