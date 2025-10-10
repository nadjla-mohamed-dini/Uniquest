using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;
    [SerializeField] private PlayerInput inputs;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(this.gameObject); //Keep the GameObject actif between scenes
    }
    public static GameManager GetInstance()
    {
        return instance;
    }
    public PlayerInput GetInput()
    {
        return inputs;
    } 
}
