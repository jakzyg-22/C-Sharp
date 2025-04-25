using System.Runtime.CompilerServices;

namespace RPG_Game;

public class Quest
{
    public string QuestName { get; set; }
    public string QuestDescription { get; set; }
    public string QuestType { get; set; }
    public string QuestReward { get; set; }
    
    public static List<Quest> GetAllQuests()
{
    return new List<Quest>
    {
        new Quest { QuestName = "Find the Magic Sword", QuestDescription = "Search the dark forest for a legendary blade.", QuestType = "Adventure", QuestReward = "100 XP" },
        new Quest { QuestName = "Defeat the Goblin Chief", QuestDescription = "Eliminate the goblin boss terrorizing the village.", QuestType = "Combat", QuestReward = "150 XP" },
        new Quest { QuestName = "Rescue the Princess", QuestDescription = "Free the princess from the haunted castle.", QuestType = "Rescue", QuestReward = "200 XP" },
        new Quest { QuestName = "Collect Healing Herbs", QuestDescription = "Gather 10 healing herbs from the meadow.", QuestType = "Gathering", QuestReward = "50 XP" },
        new Quest { QuestName = "Escort the Merchant", QuestDescription = "Protect a merchant on the way to the next city.", QuestType = "Escort", QuestReward = "120 XP" },
        new Quest { QuestName = "Slay the Cave Troll", QuestDescription = "Destroy the troll hiding in the nearby cave.", QuestType = "Combat", QuestReward = "180 XP" },
        new Quest { QuestName = "Retrieve the Lost Ring", QuestDescription = "Find the ring lost near the riverbank.", QuestType = "Search", QuestReward = "60 XP" },
        new Quest { QuestName = "Deliver a Message", QuestDescription = "Bring a sealed scroll to the city guard captain.", QuestType = "Delivery", QuestReward = "40 XP" },
        new Quest { QuestName = "Clean the Bandit Camp", QuestDescription = "Wipe out a group of forest bandits.", QuestType = "Combat", QuestReward = "170 XP" },
        new Quest { QuestName = "Explore the Ancient Ruins", QuestDescription = "Map out an old ruin and return safely.", QuestType = "Exploration", QuestReward = "90 XP" },
        new Quest { QuestName = "Harvest Rare Crystals", QuestDescription = "Mine 5 crystals from the mountain cave.", QuestType = "Gathering", QuestReward = "80 XP" },
        new Quest { QuestName = "Catch the Escaped Chicken", QuestDescription = "A farmer lost a magical chicken—bring it back.", QuestType = "Humor", QuestReward = "30 XP" },
        new Quest { QuestName = "Defend the City Gates", QuestDescription = "Help guards fend off waves of monsters.", QuestType = "Defense", QuestReward = "200 XP" },
        new Quest { QuestName = "Hunt the Silver Wolf", QuestDescription = "Track and slay a legendary silver wolf.", QuestType = "Hunt", QuestReward = "160 XP" },
        new Quest { QuestName = "Study the Magic Runes", QuestDescription = "Copy ancient runes from the mountainside.", QuestType = "Research", QuestReward = "70 XP" },
        new Quest { QuestName = "Poison the Well", QuestDescription = "Sabotage the enemy camp by poisoning their water.", QuestType = "Stealth", QuestReward = "110 XP" },
        new Quest { QuestName = "Win the Tavern Brawl", QuestDescription = "Defeat 3 fighters in the tavern's secret arena.", QuestType = "Combat", QuestReward = "90 XP" },
        new Quest { QuestName = "Sneak into the Thieves’ Den", QuestDescription = "Gather intel without being seen.", QuestType = "Stealth", QuestReward = "100 XP" },
        new Quest { QuestName = "Free the Cursed Souls", QuestDescription = "Release spirits trapped in the graveyard.", QuestType = "Mystic", QuestReward = "130 XP" },
        new Quest { QuestName = "Bake a Cake for the King", QuestDescription = "Help the royal chef bake a legendary cake.", QuestType = "Fun", QuestReward = "20 XP" }
    };
}

}