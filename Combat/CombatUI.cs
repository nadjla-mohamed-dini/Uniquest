using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CombatUI : MonoBehaviour
{
    public TextMeshProUGUI playerNameText;
    public Slider playerHPBar;
    public TextMeshProUGUI playerHPText;
    public Button attackButton;
    public TextMeshProUGUI enemyNameText;
    public Slider enemyHPBar;
    public TextMeshProUGUI enemyHPText;


    private CombatManager combatManager;

    void Start()
    {
        combatManager = FindFirstObjectByType<CombatManager>();
        attackButton.onClick.AddListener(OnAttackButtonClicked);
    }

    public void UpdatePlayerUI(Player player)
    {
        playerNameText.text = player.Name;
        playerHPBar.maxValue = 100; 
        playerHPBar.value = player.HP;
        playerHPText.text = $"{player.HP} HP";
    }
    public void UpdateEnemyUI(Enemy enemy)
    {
        enemyNameText.text = enemy.Name;
        enemyHPBar.maxValue = 100; 
        enemyHPBar.value = enemy.HP;
        enemyHPText.text = $"{enemy.HP} HP";
    }


    void OnAttackButtonClicked()
    {
        combatManager.PlayerAttack();
    }
}
