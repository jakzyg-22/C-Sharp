using System;

namespace Zestaw6Zadanie1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stworzenie dwóch macierzy 3x3
            Macierz m1 = new Macierz(3, 3);
            Macierz m2 = new Macierz(3, 3);

            Console.WriteLine("Macierz 1: ");
            Console.WriteLine(m1);

            Console.WriteLine("Macierz 2: ");
            Console.WriteLine(m2);

            // Dodawanie
            Macierz suma = m1 + m2;
            Console.WriteLine("Suma to: " + suma);

            // Mnożenie przez liczbę
            Macierz mnozenie = 2.5 * m1;
            Console.WriteLine("Macierz 1 pomnożona przez 2.5: " + mnozenie);

            // Transpozycja
            Macierz transpozycja = m1.Transpozycja();
            Console.WriteLine("Transpozycja macierzy 1: " + transpozycja);
        }
        
        // Pomocnicza metoda do wyświetlania macierzy, bo klasa nie powinna nic wyswietlac
        public void Wyswietl(double?[,] tab)
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    Console.Write($"{tab[i, j]:F2}");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

    }
}