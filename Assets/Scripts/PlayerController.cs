using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public Boolean isPlayerOne;
    public Rigidbody2D rg;
    private InputAction moveAction;
    private InputAction jumpAction;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the references to the "Move" and "Jump" actions
        moveAction = InputSystem.actions.FindAction("Move");
        jumpAction = InputSystem.actions.FindAction("Jump");
    }

    // Update is called once per frame
    void Update()
    {
        if (isPlayerOne)
        {
            Vector2 moveValue = moveAction.ReadValue<Vector2>();
            // your movement code here
            if (rg != null)
            {
                rg.linearVelocity = new Vector2(0, moveValue.y * 20);
                Debug.Log("MoveValue" + moveValue);
                if (jumpAction.IsPressed())
                {
                    Debug.Log("Jump pressed");
                }    
            }
            
        }
    }
}
