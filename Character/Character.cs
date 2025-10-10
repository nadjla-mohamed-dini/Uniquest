using System;
using System.Collections.Generic;
using UnityEngine;



public class Character : MonoBehaviour
{
    //attributes
    [Header("Stats")]
    [SerializeField] private string characterName;
    [SerializeField] private int level;
    [SerializeField] private int hp;
    [SerializeField] private int mp;
    [SerializeField] private int attack;
    [SerializeField] private int defense;
    [SerializeField] private int speed;
    [SerializeField] private int accuracy;
    [SerializeField] private CharacterType type;
    [SerializeField] private List<Attack> attacks = new List<Attack>();


    //public proporties (pour que les autres script puisse lire)
    public string Name => characterName;
    public int Level { get; protected set; } // pour utiliser dans la class player 

    public int MP => mp;
    public int HP => hp;
    public int Attack => attack;
    public int Defense => defense;
    public int Speed => speed;
    public int Accuracy => accuracy;
    public CharacterType Type => type;
    public List<Attack> Attacks => attacks;

    public void TakeDamage(int damage)
    {
        int finalDamage = Mathf.Max(0, damage - defense);
        hp = Mathf.Max(0, hp - finalDamage);

        Debug.Log($"{characterName} take {finalDamage} degat! HP restant {hp}");

    }

    public void UseAttack(Character target, Attack atk)
    {
        if (mp < atk.ManaCost)
        {
            Debug.Log($"{characterName} d'int have enough MP for {atk.Name}!");
            return;
        }
        mp -= atk.ManaCost;
        // verif precision
        float HitsTarget = accuracy / 100f;
        if (UnityEngine.Random.value > HitsTarget)
        {
            Debug.Log($"{characterName} rate {atk.Name} !");
            return;
        }
        int damage = atk.CalculateDamage() + attack;
        target.TakeDamage(damage);


        Debug.Log($"{characterName} use {atk.Name} on {target.Name} and inflect {damage} damage !");

    }

    public virtual void GainExperience(int exp)
    {
        level += exp; //would be ameliored
        Debug.Log($"{characterName} win {exp} XP. New level {level}");
    }
    public void Heal(int amount)
    {
        hp = Mathf.Min(hp + amount, 100); // par ex. 100 = HP max
        Debug.Log($"{Name} est soigné de {amount} points de vie !");
    }
    public void ModifyAttack(int value)
    {
        attack += value;
        Debug.Log($"{Name}'s attack changed by {value}. New attack: {attack}");
    }
    protected virtual void OnDeath()
    {
    Debug.Log($"{Name} est KO !");
    //can be override on player and enemy file
    }



    
}
