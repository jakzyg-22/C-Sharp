using System.Net;

namespace To_Do_List;

class Program
{
    static List<task_of> exercise = new List<task_of>();

    static void Main(string[] args)
    {
        Console.WriteLine("----- To-Do List -----");
        List();
    }

    static void List()
    {
        while (true)
        {
            Console.WriteLine("1. Dodaj zadanie");
            Console.WriteLine("2. Wyświetl aktualna listę zadań");
            Console.WriteLine("3. Usuń zadanie");
            Console.WriteLine("4. Odhacz wykonane");
            Console.WriteLine("5. Zapisz zadania do pliku");
            Console.WriteLine("6. Wczytaj dane z pliku");
            Console.WriteLine("7. Wyjście");
            Console.Write("Wpisz cyfre aby wykonać odpowiednią operację: ");
            string sign = Console.ReadLine();
            switch (sign)
            {
                case "1":
                    AddTask();
                    break;
                case "2":
                    DisplayTasks(exercise);
                    break;
                case "3":
                    RemoveTask();
                    break;
                case "7":
                    Exit();
                    return;
                case "4":
                    CheckedList();
                    break;
                case "5":
                    SaveAsTXT();
                    break;
                case "6":
                    LoadFrom();
                    break;
            }
        }
    }

    static void CheckedList()
    {
        Console.Clear();
        for (int i = 0; i < exercise.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {exercise[i]}");
        }

        Console.WriteLine("Podaj numer zadania które zostało wykonane: ");
        int userInput = int.Parse(Console.ReadLine());
        exercise[userInput - 1].Done = true;
        Console.Clear();
    }

    static void AddTask()
    {
        while (true)
        {
            Console.Clear();
            Console.Write("Wpisz zadanie, które chcesz dodać do listy: ");
            string userInput = Console.ReadLine();
            exercise.Add(new task_of(userInput));
            Console.WriteLine("Zadanie dodane!");

            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("1. Dodaj kolejne zadanie");
            Console.WriteLine("2. Powrót do menu");
            Console.Write("Wybierz opcję: ");
            string choose = Console.ReadLine();
            if (choose == "2")
            {
                Console.Clear();
                break;
            }
        }
    }

    static void RemoveTask()
    {
        {
            while (true)
            {
                Console.Clear();
                for (int i = 0; i < exercise.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {exercise[i]}");
                }

                Console.WriteLine("Podaj numer zadania które chcesz usunąć: ");
                bool success = int.TryParse(Console.ReadLine(), out int userInput);

                if (success && userInput >= 1 && userInput <= exercise.Count)
                {
                    exercise.RemoveAt(userInput - 1);
                    Console.WriteLine("Zadanie usunięte!");
                }
                else
                {
                    Console.WriteLine("Niepoprawny numer zadania!");
                }

                Console.WriteLine("-----------------------------------------------");
                Console.WriteLine("Chcesz usunąć kolejne zadanie? 1. Tak 2. Nie");
                string choose = Console.ReadLine();

                if (choose != "1")
                {
                    Console.Clear();
                    break;
                }
            }
        }
    }

    static void DisplayTasks(List<task_of> tasks)
    {
        Console.Clear();
        Console.Write("Lista aktualnych zadań: ");
        for (int i = 0; i < exercise.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {exercise[i]}");
        }

        Console.WriteLine("Wciśnij dowolny przycisk aby wrócić do menu....");
        Console.ReadKey();
        Console.Clear();
    }

    static void Exit()
    {
        Console.Clear();
        Console.WriteLine("Zamykanie programu...");
        return;
    }

    static void SaveAsTXT()
    {
        string path = "/Users/mac/Desktop/SAP/zadanie.csv";
        using (StreamWriter writer = new StreamWriter(path))
        {
            foreach (var zadanie in exercise)
            {
                writer.WriteLine($"{zadanie.Done},{zadanie.Description}");
            }
        }

        Console.WriteLine("Zadania zostały zapisane do pliku!");
        Console.WriteLine("Wciśnij dowolny klawisz...");
        Console.ReadKey();
        Console.Clear();
    }

    static void LoadFrom()
    {
        Console.Clear();
        Console.WriteLine("Podaj ścieżkę pliku docelowego: ");
        string sciezka = Console.ReadLine();
        while (true)
        {
            try
            {
                if (!File.Exists(sciezka))
                {
                    Console.WriteLine("Nie podano poprawnej ścieżki!");
                    break;
                }
                else
                {
                    string[]
                        lines = File.ReadAllLines(sciezka); //odczytuje wszystkie linie z podanego pliku txt, lub csv 
                    foreach (var line in lines)
                    {
                        string[]
                            splitted = line
                                .Split(','); //jako separatora użyty "," po to aby była możliwość wczytania z pliku csv lub txt
                        if (splitted.Length == 2)
                        {
                            bool done = bool.Parse(splitted[0]);
                            string opis = splitted[1];
                            exercise.Add(new task_of(opis) { Done = done });
                        }
                    }

                    Console.Clear();
                    Console.WriteLine("Dane z pliku zostały wczytane, wciśnij dowolny przycisk aby wrócić...");
                    Console.ReadKey();
                    break;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Wystąpił błąd: " + e.Message);
                Console.WriteLine("Wciśnij dowolny klawisz, aby wrócić do menu...");
                Console.ReadKey();
                Console.Clear();
                break;
            }
        }

    }
}