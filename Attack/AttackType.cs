using System;
using UnityEngine;

public enum AttackType
{
    Physique,
    Magique,
    Special
}
[System.Serializable] // ajouter sa pour que ce soit visible dans l'inspecteur nadjla
public class Attack
{
    public string Name;
    public AttackType Type;
    public int Power; // Puissance
    public int Accuracy; // Precision
    public int ManaCost; // Coût en mana
    public float CritChance = 0.1f; // Coup critique chance
    public float CritMultiplier = 1.5f; // Multiplicateur en cas de critique

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

    public bool HitsTarget()
    {
        return UnityEngine.Random.Range(0, 100) < Accuracy; // enlever random pour mettre unity.engine random(plus coherent avec unity) nadjla
    }

    public bool IsCritical()
    {
        return UnityEngine.Random.value < CritChance; // same here nadjla
    }

    public int CalculateDamage()
    {
        int baseDamage = Power;
        if (IsCritical())
        {
            baseDamage = Mathf.RoundToInt(baseDamage * CritMultiplier);
            Debug.Log("Coup critique !");
        }
        return baseDamage;
    }
}