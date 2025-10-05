using System;
using System.Collections.Generic;
using UnityEngine;



public class Character : MonoBehaviour
{
    //attributes
    private string characterName;
    private int level;
    private int hp;
    private int mp;
    private int attack;
    private int defense;
    private int speed;
    private int accuracy;
    private CharacterType type;
    [SerializeField] private List<Attack> attacks = new List<Attack>();


    //public proporties (pour que les autres script puisse lire)
    public string Name => characterName;
    public int Level => level;

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
        int damage = atk.Power + attack;
        target.TakeDamage(damage);

        Debug.Log($"{characterName} use {atk.Name} on {target.Name} and inflect {damage} damage !");

    }

    public void GainExperience(int exp) {
        level += exp; //would be ameliored
        Debug.Log($"{characterName} win {exp} XP. New level {level}");
    }
}
