namespace Programowaniekolos;

class Program
{
    static void Main(string[] args) //metoda ktora tworzy tablice
    {
        int[,] tablica = new int[3, 3];
        Random rnd = new Random();

        for (int i = 0; i < tablica.GetLength(0); i++)
        {
            for (int j = 0; j < tablica.GetLength(1); j++)
            {
                tablica[i, j] = rnd.Next(1, 11);
            }
        }
        wyswietlanie(tablica); //wyswietlanie tablicy poprzez wywolanie metody
        int suma = liczbaParzystaje(tablica);
        Console.WriteLine($"Ilosc liczb parzystych: {suma}");
    }

    static int liczbaParzystaje(int[,] tablica) //metoda ktora sprawdza parzystosc liczby
    {
        int liczba = 0;
        for (int i = 0; i < tablica.GetLength(0); i++) //przechodzimy przez kazdy element tej tablicy i sprawdzamy czy jest parzysty
        {
            for (int j = 0; j < tablica.GetLength(1); j++)
            {
                if (tablica[i, j] % 2 == 0) //tablica[i, j] oznacza dany wiersz i kolumne wybranego elementu, jak w macierzach
                {
                    liczba++; //jesli liczba jest parzysta zwieksza sie ilosc liczb parzystych o 1, czyli z 0 do 1
                }
            }
        }
        return liczba;
    }
    static void wyswietlanie(int[,] tablica) //metoda ktora wyswietla tablice
    {
        for (int i = 0; i < tablica.GetLength(0); i++)
        {
            for (int j = 0; j < tablica.GetLength(1); j++)
            {
                Console.Write(tablica[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
