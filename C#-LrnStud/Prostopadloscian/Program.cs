namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        Prostopadloscian p1 = new Prostopadloscian();
        Prostopadloscian p2 = new Prostopadloscian(1,1, 1);
        Prostopadloscian p3 = new Prostopadloscian();
        if (p1.Porownanie(p2))
        {
            Console.WriteLine("Maja ta sama objetosc");
        }
        else
        {
            Console.WriteLine("Maja inna objetosc");
        }
        Console.WriteLine(p3.Objetosc());
    }
}