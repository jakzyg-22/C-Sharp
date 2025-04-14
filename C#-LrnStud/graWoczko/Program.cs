using System;

namespace GraWoczko
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int suma = 0;
            int liczbaAsow = 0; // Liczy ilość wylosowanych asów (11)
            string decyzja;

            Console.WriteLine("Gramy w oczko!");

            do
            {
                int karta = rnd.Next(2, 12); // Losujemy kartę z zakresu 2-11
                suma += karta;

                // Sprawdzamy, czy karta to as (11)
                if (karta == 11)
                {
                    liczbaAsow++;
                }

                Console.WriteLine($"Wylosowałeś kartę o wartości: {karta}. Suma wynosi: {suma}");

                // Warunek wygranej – Oczko (21 punktów)
                if (suma == 21)
                {
                    Console.WriteLine("Brawo! Masz oczko!");
                    break;
                }

                // Warunek wygranej – Oczko perskie (dwa asy)
                if (liczbaAsow == 2)
                {
                    Console.WriteLine("Brawo! Masz oczko perskie!");
                    break;
                }

                // Warunek przegranej – przekroczenie 21 punktów
                if (suma > 21)
                {
                    Console.WriteLine("Przegrałeś! Suma przekroczyła 21.");
                    break;
                }

                // Pytamy użytkownika, czy chce pobrać kolejną kartę
                Console.Write("Czy chcesz pobrać kolejną kartę? (t/n): ");
                decyzja = Console.ReadLine().ToLower();

            } while (decyzja == "t");

            Console.WriteLine("Koniec gry!");
        }
    }
}