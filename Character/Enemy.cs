using UnityEngine;

public class Enemy : Character
{
    public void TakeTurn(Character target)
    {
        if (Attacks == null || Attacks.Count == 0)
        {
            Debug.Log($"{Name} n’a aucune attaque !");
            return;
        }

        Attack chosenAttack = Attacks[Random.Range(0, Attacks.Count)];

        Debug.Log($"{Name} use {chosenAttack.Name} on {target.Name} !");

        float chanceToHit = Accuracy / 100f;
        if (Random.value <= chanceToHit)
        {
            int damage = chosenAttack.Power + Attack;
            target.TakeDamage(damage);
            Debug.Log($"{target.Name} lose {damage} HP (reste {target.HP})");
        }
        else
        {
            Debug.Log($"{Name} miss his attack !");
        }
    }
    protected override void OnDeath()
    {
    Debug.Log($"{Name} est vaincu !");
    
    Player player = FindFirstObjectByType<Player>();
    if (player != null)
    {
        player.GainExperience(50); // can be modified
    }

    Destroy(gameObject); // delete the enemie
    }

}
