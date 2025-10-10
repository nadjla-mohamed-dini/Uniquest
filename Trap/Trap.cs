using UnityEngine;

public class Trap : MonoBehaviour
{
    [SerializeField] private GameObject enemyPrefab;
    [SerializeField] private Transform spawnPoint;
    private bool triggered = false;

    private void OnTriggerEnter2D(Collider2D collider) 
    {
        if (triggered)
            return;
        if (collider.CompareTag("Player"))
        {
            triggered = true;
            Debug.Log("trappe activated");
            SpawnEnemy();
        }
    }
    private void SpawnEnemy()
    {
        if (enemyPrefab == null)
        {
            Debug.LogWarning("none enemy prefab assigned");
            return;
        }
        GameObject enemyGO = Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
        Enemy enemyScript = enemyGO.GetComponent<Enemy>();

        if (enemyScript != null)
        {
            Debug.Log($"{enemyScript.Name} is here");
            
        }
    }
}
