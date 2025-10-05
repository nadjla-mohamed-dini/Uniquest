using System;

public enum AttackType
{
    Physique,
    Magique,
    Special
}

public class Attack
{
    public string Name { get; private set; }
    public AttackType Type { get; private set; }
    public int Power { get; private set; } // Puissance
    public int Accuracy { get; private set; } // Precision
    public int ManaCost { get; private set; } // Coût en mana
    public float CritChance { get; private set; } // Coup critique chance
    public float CritMultiplier { get; private set; } // Multiplicateur en cas de critique

    public Attack(string name, AttackType type, int power, int accuracy, int manaCost, float critChance = 0.1f, float critMultiplier = 1.5f)
    {
        Name = name;
        Type = type;
        Power = power;
        Accuracy = Math.Clamp(accuracy, 0, 100);
        ManaCost = manaCost;
        CritChance = Math.Clamp(critChance, 0f, 1f);
        CritMultiplier = critMultiplier;
    }

    public bool HitsTarget(Random rng)
    {
        return rng.Next(0, 100) < Accuracy;
    }

    public bool IsCritical(Random rng)
    {
        return rng.NextDouble() < CritChance;
    }

    public int CalculateDamage(Random rng)
    {
        int baseDamage = Power;
        if (IsCritical(rng))
        {
            baseDamage = (int) (baseDamage * CritMultiplier);
            Console.WriteLine("Coup critique !");
        }
        return baseDamage;
    }
}