using System;
using System.Collections.Generic;

public class TestGames
{
    public static void Main(string[] args)
    {
        // Test Attack class
        Random rng = new Random();
        Attack fireball = new Attack("Fireball", AttackType.Magique, 40, 90, 10);

        if (fireball.HitsTarget(rng))
        {
            int damage = fireball.CalculateDamage(rng);
            Console.WriteLine($"{fireball.Name}'s attack inflicted {damage} damage!");
        }
        else
        {
            Console.WriteLine($"{fireball.Name}'s attack missed!");
        }

        // Test Enemy class
        Enemy goblin = new Enemy("Gobelin", 50, 10, 5, 20, 3);
        goblin.Attacks = new List<Attack>
        {
            new Attack("Slash", AttackType.Physique, 15, 80, 0),
            new Attack("Rock", AttackType.Physique, 15, 90, 0),
            new Attack("Sound", AttackType.Special, 10, 100, 0),
        };

        Character hero = new Character("Heros", 100, 20, 10, 30, 5);

        goblin.TakeTurn(hero);

    }
}