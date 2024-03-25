namespace _036_war_preparations;

public enum Materials
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Binarium
};

public enum GemStones
{
    Emerald,
    Amber,
    Sapphire,
    Diamond,
    Bitstone,
    None
};

public record Sword
(
    Materials SwordMaterial, 
    GemStones SwordGemStone,
    float Length,
    float CrossguardWidth
);