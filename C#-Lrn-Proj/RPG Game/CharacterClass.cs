public class CharacterClass
{
    public string ClassName { get; private set; }
    public int XP { get; private set; }
    public int Level { get; private set; }
    public int Strength { get; private set; }
    public int Agillity { get; private set; }
    public int Magic { get; private set; }

    public CharacterClass(string className, int xp, int level, int strength, int agillity, int magic)
    {
        ClassName = className;
        XP = xp;
        Level = level;
        Strength = strength;
        Agillity = agillity;
        Magic = magic;
    }

    public static CharacterClass Wizard()
    {
        return new CharacterClass("Wizard", 0, 1, 10, 15, 40);
    }

    public static CharacterClass Warrior()
    {
        return new CharacterClass("Warrior", 0, 1, 30, 10, 5);
    }

    public static CharacterClass Archer()
    {
        return new CharacterClass("Archer", 0, 1, 20, 25, 10);
    }

    public void ShowStats()
    {
        Console.WriteLine($"Class: {ClassName}");
        Console.WriteLine($"Level: {Level}");
        Console.WriteLine($"XP: {XP}");
        Console.WriteLine($"Strength: {Strength}");
        Console.WriteLine($"Agility: {Agillity}");
        Console.WriteLine($"Magic: {Magic}");
    }
}