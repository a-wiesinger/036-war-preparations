using _036_war_preparations;

// Create single instance of iron sword with no gem
Sword plainIronSword = new Sword
(
    SwordMaterials.Iron, SwordGemStones.None, 500, 35
);

Console.WriteLine($"This is an iron sword: {plainIronSword}");

// TODO - Create two variations using WITH expressions to replace values