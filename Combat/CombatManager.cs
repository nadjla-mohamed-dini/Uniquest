using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public Player player;
    public Enemy enemy;
    private bool playerTurn = true;
    [SerializeField] private CombatUI ui;

    public void PlayerAttack()
    {
        if (!playerTurn)
            return;

        if (player.Attacks == null || player.Attacks.Count == 0)
        {
            Debug.Log($"{player.Name} aucune attaque");
            return;
        }
        //choose a random attack
        int index = UnityEngine.Random.Range(0, player.Attacks.Count);
        Attack atk = player.Attacks[index];


        player.UseAttack(enemy, atk);
        //Maj UI
        ui.UpdatePlayerUI(player);
        ui.UpdateEnemyUI(enemy);


        playerTurn = false;
        Invoke(nameof(EnemyTurn), 1f);
    }
    public void EnemyTurn()
    {
        enemy.TakeTurn(player);

        ui.UpdatePlayerUI(player);
        ui.UpdateEnemyUI(enemy);

        playerTurn = true;
        ShowCombatOptions();
    }

    public void ShowCombatOptions()
    {
        //activer buton
        Debug.Log("choose your action");
    }
    


    public void StartCombat(Player p, Enemy e)
    {
        player = p;
        enemy = e;
        playerTurn = true;

        Debug.Log("Combat started!");

        if (ui == null)
            ui = FindFirstObjectByType<CombatUI>();

        ui.UpdatePlayerUI(player);
        ShowCombatOptions();
    }



}
