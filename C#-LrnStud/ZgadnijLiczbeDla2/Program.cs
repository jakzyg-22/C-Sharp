namespace ZgadnijLiczbeDla2;

class Program
{
    static void Main(string[] args)
    {
        //GRACZ1
        Console.Write("Niech pierwszy gracz poda liczbę: ");
        int liczba1;
        int zgadnijliczbe;
        int proba = 0;
        while (true)
        {
            if (int.TryParse(Console.ReadLine(), out liczba1) && liczba1 >= 1 && liczba1 <= 100)
            {
                Console.Clear();
                Console.WriteLine("Liczba została zapamiętana, teraz kolej 2 gracza!");
                break;
            }
            else
            {
                Console.WriteLine("Wprowadziłeś niepoprawną liczbę!");
            }
        }
        
        //GRACZ2
        while (true)
        {
            Console.WriteLine("Spróbuj zgadnąć liczbę Gracza1: ");
            if (int.TryParse(Console.ReadLine(), out zgadnijliczbe) && zgadnijliczbe >= 1 && zgadnijliczbe <= 100)
            {
                proba++;
                if (zgadnijliczbe == liczba1)
                {
                    Console.WriteLine($"Zgadłeś liczbę 1 gracza za {proba} razem");
                    break;
                }
                else if (zgadnijliczbe < liczba1)
                {
                    Console.WriteLine("Liczba jest za mała!");
                    Console.WriteLine($"Próba nr: {proba}");
                }
                else if (zgadnijliczbe > liczba1)
                {
                    Console.WriteLine("Liczba jest za duża!");
                    Console.WriteLine($"Próba nr: {proba}");
                }
            }
            else
            {
                Console.WriteLine("Wpisałeś liczbę spoza dozwolonego zakresu!");
            }
        }
    }
}