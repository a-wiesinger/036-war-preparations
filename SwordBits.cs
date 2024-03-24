namespace _036_war_preparations;

public enum SwordMaterials
{
    Wood,
    Bronze,
    Iron,
    Steel,
    Binarium
};

public enum SwordGemStones
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
    SwordMaterials SwordMat, 
    SwordGemStones SwordGemSt,
    float Length,
    float CrossguardWidth
);