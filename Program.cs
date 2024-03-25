using _036_war_preparations;

// Create single instance of iron sword with no gem
Sword plainSword = new Sword
(
    Materials.Iron, GemStones.None, 500, 35
);

// Create two variations using WITH expressions to replace values
Sword bronzeEmeraldSword = plainSword with
{
    SwordMaterial = Materials.Bronze,
    SwordGemStone = GemStones.Emerald,
    Length = 900,
    CrossguardWidth = 20
};

Sword binariumDiamondSword = plainSword with
{
    SwordMaterial = Materials.Binarium,
    SwordGemStone = GemStones.Diamond,
    Length = 2000,
    CrossguardWidth = 50
};

Sword[] allSwords = new Sword[] { plainSword, bronzeEmeraldSword, binariumDiamondSword };

foreach (var sword in allSwords)
{
    Console.WriteLine(sword);
}