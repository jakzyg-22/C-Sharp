namespace ZgadnijLiczbe;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Podaj liczbe od 1 do 100: ");
        int liczba;
        int licznik = 0;
        int rand = new Random().Next(1, 101);
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out liczba) && liczba <= 100 && liczba >= 1)
            {
                licznik++;
                if (liczba == rand)
                {
                    Console.WriteLine($"Gratulacje, zgadłeś liczbę o której myślałem! Liczba to: {liczba}");
                    Console.WriteLine($"Udało ci się to za {licznik} razem!");
                    break;
                }
                else if (liczba > rand)
                {
                    Console.WriteLine("Niestety nie udało ci się, próbuj dalej! Liczba jest za duża!");
                    Console.WriteLine($"Próba nr: {licznik}");
                }
                else if (liczba < rand)
                {
                    Console.WriteLine("Niestety nie udało ci się, próbuj dalej! Liczba jest za mała!");
                    Console.WriteLine($"Próba nr: {licznik}");
                }
            }
            else
            {
                Console.WriteLine("Podana przez ciebie liczba jest nieprawidłowa!");
            }
        }
    }
}