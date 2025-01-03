using System.Collections;   
using System.Collections.Generic;   
using UnityEngine;

public class Player: MonoBehaviour
{
    public float velocidade = 10;
    public float rotacao = 100;
    void Start()
    {
        

    }

    void Update()
    {
        float vertical = InputManager.GetMovementInput().y;
        float horizontal = InputManager.GetMovementInput().x;
        transform.Translate(0, 0, velocidade * Time.deltaTime * vertical);
        transform.Rotate(0, rotacao * Time.deltaTime * Input.GetAxis("Horizontal"), 0);
    
        if(InputManager.GetFireInput())
        {
            Debug.Log("Atirou");
        }

        if (InputManager.GetRunInput())
        {
            Debug.Log("Correu");
        }

    }
            
}
