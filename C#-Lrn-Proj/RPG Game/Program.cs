using System;
using System.Collections.Generic;
using System.Linq;
using RPG_Game;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome in my RPG Game!");
        Select();
    }

    static void Select()
    {
        Console.WriteLine("---------------------");
        Console.WriteLine("| Select your class |");
        Console.WriteLine("| 1. Wizard         |");
        Console.WriteLine("| 2. Warrior        |");
        Console.WriteLine("| 3. Archer         |");
        Console.WriteLine("---------------------");
        Console.Write("Write number: ");

        bool selection = int.TryParse(Console.ReadLine(), out int selected);

        CharacterClass character = null;

        switch (selected)
        {
            case 1:
                character = CharacterClass.Wizard();
                Console.Clear();
                VisualizationWizard();
                break;
            case 2:
                character = CharacterClass.Warrior();
                Console.Clear();
                VisualizationWarrior();
                break;
            case 3:
                character = CharacterClass.Archer();
                Console.Clear();
                VisualizationArcher();
                break;
            default:
                Console.WriteLine("Invalid number. Exiting...");
                return;
        }

        Console.WriteLine($"You are a {character.ClassName}!");
        Console.WriteLine("STATS: ");
        character.ShowStats();

        CharacterName();
        Console.Clear();
        List<Quest> allQuests = Quest.GetAllQuests();
        List<Quest> randomQuests = GetRandomQuests(allQuests);
        ShowQuests(randomQuests);
    }

    static void CharacterName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.WriteLine("Your name is " + name);
    }

    static void ShowQuests(List<Quest> quests)
    {
        Console.WriteLine("\nAvailable quests:");
        int index = 1;
        foreach (var quest in quests)
        {
            Console.WriteLine($"{index}. {quest.QuestName} - {quest.QuestDescription} [{quest.QuestReward}]");
            index++;
        }

        Console.Write("\nChoose a quest (1-4): ");
        bool valid = int.TryParse(Console.ReadLine(), out int questChoice);

        if (valid && questChoice >= 1 && questChoice <= quests.Count)
        {
            Quest chosenQuest = quests[questChoice - 1];
            Console.WriteLine($"\nYou accepted the quest: {chosenQuest.QuestName}!");
            Console.WriteLine($"Reward: {chosenQuest.QuestReward}");
        }
        else
        {
            Console.WriteLine("Invalid quest number.");
        }
    }

    static List<Quest> GetRandomQuests(List<Quest> allQuests)
    {
        Random rng = new Random();
        return allQuests.OrderBy(q => rng.Next()).Take(4).ToList();
    }

    static void VisualizationWizard()
    {
        Console.WriteLine("                    ____ ");
        Console.WriteLine("                  .'* *.'");
        Console.WriteLine("               __/_*_*(_");
        Console.WriteLine("              / _______ \\");
        Console.WriteLine("             _\\_)/___\\(_/_ ");
        Console.WriteLine("            / _((\\- -/))_ \\");
        Console.WriteLine("            \\ \\())(-)(()/ /");
        Console.WriteLine("             ' \\(((()))/ '");
        Console.WriteLine("            / ' \\)).))/ ' \\");
        Console.WriteLine("           / _ \\ - | - /_  \\");
        Console.WriteLine("          (   ( .;''';. .'  )");
        Console.WriteLine("          _\\\"__ /    )\\ __\"/_");
        Console.WriteLine("            \\/  \\   ' /  \\/");
        Console.WriteLine("             .'  '...' ' )");
        Console.WriteLine("              / /  |  \\ \\");
        Console.WriteLine("             / .   .   . \\");
        Console.WriteLine("            /   .     .   \\");
        Console.WriteLine("           /   /   |   \\   \\");
        Console.WriteLine("         .'   /    b    '.  '.");
        Console.WriteLine("     _.-'    /     Bb     '-. '-._ ");
        Console.WriteLine(" _.-'       |      BBb       '-.  '-. ");
        Console.WriteLine("(________mrf\\____.dBBBb.________)____)");
    }

    static void VisualizationWarrior()
    {
        Console.WriteLine(@"
              {}
             {{}}
             {{}}
              {}
            .-''-.
           /  __  \
          /.-'  '-.\
          \::.  .::/
           \'    '/
      __ ___)    (___ __
    .'   \\        //   `.
   /     | '-.__.-' |     \
   |     |  '::::'  |     |
   |    /    '::'    \    |
   |_.-;\     __     /;-._|
   \.'^`\\    \/    //`^'./
   /   _.-._ _||_ _.-._   \
  `\___\    '-..-'    /___/`
       /'---.  `\.---'\
      ||    |`\\\|    ||
      ||    | || |    ||
      |;.__.' || '.__.;|
      |       ||       |
      {{{{{{{{||}}}}}}}}
       |      ||      |
       |.-==-.||.-==-.|
       <.    .||.    .>
        \'=='/||\'=='/
        |   / || \   |
        |   | || |   |
        |   | || |   |
        /^^\| || |/^^\
       /   .' || '.   \
      /   /   ||   \   \
     (__.'    \/    '.__)
");
    }

    static void VisualizationArcher()
    {
        Console.WriteLine(@"
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣴⣶⣶⣶⣶⣖⢤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣏⣗⢃⣝⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢸⡿⢿⣿⣿⣿⣿⣿⣿⢿⠏⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢠⣿⢶⠠⢾⡿⡻⣿⣿⡟⣤⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠉⢿⣆⣀⡄⢼⢙⣿⣿⣿⣿⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣼⣿⣟⣛⠵⣿⣿⣿⣷⣿⣷⣤⣶⣇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⣿⣿⣿⣿⣿⠟⣠⣾⣿⣿⣿⣿⣿⣿⣿⣿⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⣼⣽⣿⣿⣿⣿⣥⣾⣿⣿⢿⣿⣿⢿⣿⡿⢿⣏⠇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣽⣿⣿⣿⢿⡧⠖⣛⠛⣺⣷⣾⣿⣿⣿⣿⣧⣄⢫⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⢻⣋⣡⣎⣀⣠⣶⣿⣿⣿⣿⣿⣿⣿⢿⣿⡿⡙⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠻⣿⣷⣿⣿⣿⣿⣿⣿⣿⣿⢿⣿⣿⣿⣷⣱⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣟⣿⣿⡿⣿⣿⣿⣿⣟⢏⢿⣷⣿⣿⣿⡃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢻⠛⠉⠙⠋⠁⠀⠉⣿⣿⣾⣿⣿⣿⡿⠉⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠘⡄⠀⠀⠀⠜⢀⣀⣸⡻⣋⣁⣯⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⣇⠁⠀⠀⠚⠁⣤⣤⣽⠟⣾⣿⣹⣾⠃⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣀⢴⣿⣿⣄⣀⣀⣠⣾⣿⣿⡇⣼⣿⣿⡏⢁⡀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣠⠦⢄⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣿⣿⡿⠛⣩⣿⣿⣿⣿⣷⣯⣿⣷⣽⣿⣿⡿⠟⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⢀⢴⡿⠋⠩⠧⠃⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⡼⠋⢹⠀⠀⣻⣿⣿⣿⣿⣾⣿⡿⣿⣿⣿⣿⣧⢢⠔⠂⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⢀⢔⠕⠉⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⣾⣾⣟⢼⠀⣴⣿⣿⣾⣿⣿⣿⡟⢻⣯⣿⣿⣿⣿⡇⡆⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⡠⣾⠗⠁⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠤⠼⢿⣾⣿⣾⣿⣿⣷⣿⣿⣿⣿⣽⡇⣜⣿⣿⣿⣿⣿⣇⡇⠀⠀⠀⠀⠀⠀⢀⡠⣔⡽⠚⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⣀⣀⣠⠤⠀⠒⠂⠀⠀⠀⠀⠀⠀⠀⠀⠘⠻⣿⣿⣿⣿⣿⣿⣿⣯⣿⣿⣿⣿⣻⣿⣿⣿⣿⣿⡇⠀⠀⢀⡠⢔⣪⠵⠛⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⣿⣋⠉⠒⠻⠵⣖⡤⢄⣀⠀⠀⠀⠀⠀⠀⠀⠀⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⡿⣹⣿⡃⣿⣿⠿⠿⠑⣒⣯⠵⠛⠋⠁⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠈⠉⠀⠀⠀⠀⠀⠈⠙⠓⠫⠭⣒⣶⣂⣤⢤⡴⡿⠿⡿⡿⡯⠛⠛⣻⣭⣮⣽⣿⣽⣽⣿⣾⣯⣿⣿⠉⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠈⠉⢩⣿⣷⢻⣿⣿⣟⣿⣿⣿⣻⣿⣿⣿⣿⣿⣿⣿⣿⣿⡇⡄⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⣾⣿⣿⣽⣿⣿⣿⣿⣿⣿⣿⣿⣿⢽⣿⣿⣿⣿⣿⡟⣇⡇⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀⠀
");
    }
}
