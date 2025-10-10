using System.Collections.Generic;
using UnityEngine;

public class Player : Character
{
    [Header("Player Settings")]
    [SerializeField] private Inventory inventory;
    [SerializeField] private int experience = 0;
    


    private const int EXP_PER_LEVEL = 100;

    public Inventory Inventory => inventory; 
    public int Experience => experience;
    


    public override void GainExperience(int amount) // on override la methode 
    {
        experience += amount;
        Debug.Log($"{Name} win {amount} experience point. Total: {experience}");

        if (experience >= EXP_PER_LEVEL)
        {
            Level++;
            experience -= EXP_PER_LEVEL;
        }
    }
    protected override void OnDeath()
    {   
    Debug.Log($"{Name} is dead ! Game Over.");

    }


}
