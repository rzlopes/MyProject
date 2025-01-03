using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{
    public static InputManager instance;    

    Vector2 movementInput;
    bool fireInput;
    bool runInput;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void LateUpdate()
    {
        fireInput = false;
    }

    public void OnMove(InputValue value)
    {
        movementInput = value.Get<Vector2>();
        InputManager.GetMovementInput();
    }

    public void OnFire(InputValue value) {
        fireInput = value.isPressed;
        InputManager.GetFireInput();   
    }   
    public void OnRun(InputValue value) {
        runInput = value.isPressed;
        InputManager.GetRunInput();
    }

    public static Vector2 GetMovementInput()
    {
        return instance.movementInput;
    }

    public static bool GetFireInput()
    {
        return instance.fireInput;
    }

    public static bool GetRunInput()
    {
        return instance.runInput;
    }    


}
