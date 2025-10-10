using System;
using UnityEngine;
using UnityEngine.InputSystem;


public class CharacterMotor : MonoBehaviour
{
    private PlayerInput inputs;

    private InputAction moveAction;
    private GameManager manager;
    private Vector2 velocity = Vector2.zero;
    [SerializeField] private float speed = 5f;
    private Animator animator;
    private int direction = 0;
    private Rigidbody2D rb;

    void Start()
    {
        manager = GameManager.GetInstance();
        inputs = manager.GetInput();
        moveAction = inputs.actions.FindAction("Move");
        animator = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Vector2 _moveInput = moveAction.ReadValue<Vector2>();
        _moveInput = ChooseDirection(_moveInput);

        // Debug.Log(_moveInput); // Keep in mind that delete it

        velocity = _moveInput * speed;
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        //Animation 
        animator.SetInteger("Direction", direction);
        Debug.Log(rb.position);

    }

    private Vector2 ChooseDirection(Vector2 _value)
    {
        Vector2 _result = Vector2.zero;

        if (Math.Abs(_value.x) >= Mathf.Abs(_value.y)) //se déplace en X
        {
            _result = new Vector2(_value.x, 0);

        }
        else //se deplace en Y 
        {
            _result = new Vector2(0, _value.y);
        }
        direction = SetDirection(_result);
        return _result;
    }

    private int SetDirection(Vector2 dir)
    {
        if (dir.x > 0) return 6;
        if (dir.x < 0) return 4;
        if (dir.y > 0) return 8;
        if (dir.y < 0) return 2;
        return 0;
    }

}
