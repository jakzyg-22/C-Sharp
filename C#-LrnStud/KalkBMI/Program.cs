namespace KalkBMI;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Podaj swoja wage w kg: ");
        double waga;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out waga) && waga > 0)
                break;
            else
                Console.WriteLine("To nie jest poprawna liczba! Waga musi być liczbą dodatnią.");
        }
        
        Console.Write("Podaj swoj wzrost w metrach (np. 183= 1,83): ");
        double wzrost;
        while (true)
        {
            if (double.TryParse(Console.ReadLine(), out wzrost) && wzrost > 0)
                break;
            else
                Console.WriteLine("Nie jest to poprawna wartosc dla wzrostu!.");
        }

        double bmi = waga / (wzrost * wzrost);
            if (bmi < 18.5)
            {
                Console.WriteLine($"Masz niedowagę! Twoje BMI: {Math.Round(bmi, 2)}");
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                Console.WriteLine($"Twoja waga jest prawidlowa. Twoje BMI: {Math.Round(bmi, 2)}");
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                Console.WriteLine($"Masz nadwagę! Twoje BMI: {Math.Round(bmi, 2)}");
            }
            else if (bmi >= 30)
            {
                Console.WriteLine($"Otyłość!!!! Twoje BMI: {Math.Round(bmi, 2)}");
            }
           
    }
}