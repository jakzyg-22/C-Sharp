using System;

class Program
{
    static List<Dzialanie> history = new List<Dzialanie>();
    static void Main()
    {
        Console.WriteLine("------KALKULATOR KONSOLOWY------");
        Calculator(); // odpalamy kalkulator
    }

    public static void Calculator()
    {
        try
        {
            while (true)
            {
                Console.Write("Wybierz operację (+, -, *, /, ^, √), lub wpisz " +
                              "'historia' aby sprawdzić operacje jakie były wykonywane" +
                              ", lub 'wyjście' aby zakończyć działanie kalkulatora: ");
                string sign = Console.ReadLine();

                if (sign == "wyjście")
                {
                    Console.Clear();
                    Console.WriteLine("Zamykanie kalkulatora...");
                    break;
                }

                if (sign == "historia")
                {
                    Console.Clear();
                    History();
                    continue;
                }

                // Operacje jednoargumentowe
                if (sign == "^" || sign == "√")
                {
                    Console.Write("Podaj liczbę do wykonania operacji: ");
                    bool success = double.TryParse(Console.ReadLine(), out double special);

                    if (!success)
                    {
                        Console.Clear();
                        Console.WriteLine("Błąd! Podano niepoprawną liczbę.");
                        continue;
                    }

                    if (sign == "^")
                    {
                        float result = (float)Math.Pow(special, 2);
                        Console.WriteLine($"Wynik: {result}");
                        history.Add(new Dzialanie((float)special, 0, "^", result));
                    }
                    else if (sign == "√")
                    {
                        if (special < 0)
                        {
                            Console.WriteLine("Nie można pierwiastkować liczby ujemnej!");
                        }
                        else
                        {
                            float result = (float)Math.Sqrt(special);
                            Console.WriteLine($"Wynik: {result}");
                            history.Add(new Dzialanie((float)special, 0, "√", result));
                        }
                    }
                }
                // Operacje dwuargumentowe
                else if (sign == "+" || sign == "-" || sign == "*" || sign == "/")
                {
                    Console.Write("Podaj pierwszą liczbę: ");
                    bool success1 = double.TryParse(Console.ReadLine(), out double a);

                    Console.Write("Podaj drugą liczbę: ");
                    bool success2 = double.TryParse(Console.ReadLine(), out double b);

                    if (!success1 || !success2)
                    {
                        Console.Clear();
                        Console.WriteLine("Błąd! Podano niepoprawne dane.");
                        continue;
                    }

                    if (sign == "+")
                    {
                        Console.Clear();
                        Console.WriteLine($"Wynik: {a + b}");
                        history.Add(new Dzialanie((float)a, (float)b, "+", (float)(a + b)));
                    }
                    else if (sign == "-")
                    {
                        Console.Clear();
                        Console.WriteLine($"Wynik: {a - b}");
                        history.Add(new Dzialanie((float)a, (float)b, "-", (float)(a - b)));

                    }
                    else if (sign == "*")
                    {
                        Console.Clear();
                        Console.WriteLine($"Wynik: {a * b}");
                        history.Add(new Dzialanie((float)a, (float)b, "*", (float)(a * b)));
                    }
                    else if (sign == "/")
                    {
                        if (b == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Błąd! Nie można dzielić przez zero.");
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine($"Wynik: {a / b}");
                            history.Add(new Dzialanie((float)a, (float)b, "/", (float)(a / b)));
                        }
                    }
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Nieznana operacja! Spróbuj ponownie.");
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Wystąpił błąd: " + ex.Message);
        }
    }

    public static void History()
    {
      Console.Clear();
      Console.WriteLine("------Historia działań------");
      if (history.Count == 0)
      {
          Console.WriteLine("Brak zapisanych działań.");
          return;
      }
      foreach (var operations in history)
      {
          Console.WriteLine(operations.ToString());
      }
      Console.WriteLine("Wciśnij dowolny klawisz aby powrócic do kalkulatora.");
      Console.ReadKey();

    }
}
