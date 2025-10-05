using System;
using System.Collections.Generic;

public class Enemy : Character
{
    private Random rng = new Random();

    public Enemy(string name, int hp, int attack, int defense, int mana, int speed)
        : base(name, hp, attack, defense, mana, speed)
    {
    }

    public Attack ChooseRandomAttack()
    {
        if (Attacks == null || Atacks.Count == 0)
        {
            Console.WriteLine($"{Name} does not have any attacks!");
            return null;
        }

        int index = rng.Next(Attacks.Count);
        return Attacks[index];
    }

    public void TakeTurn(Character target)
    {
        Attack ChosenAttack = ChoosenRandomAttack();
        if (ChosenAttack == null) return;
        Console.WriteLine($"{Name} use {ChooseRandomAttack.Name} on {target.Name}!");

        if (ChosenAttack.HitsTarget(rng))
        {
            int damage = chosenAttack.CalculateDamage(rng);
            target.TakeDamage(damage);
            Console.WriteLine($"{target.Name} lost {damage} PV (reste {target.CurrentHP})");
        }
        else
        {
            Console.WriteLine($"{Name}'s attack missed!");
        }
    }
}