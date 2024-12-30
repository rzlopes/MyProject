using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 distancia;
    void Start()
    {
        distancia = transform.position - player.position;

    }

    void LateUpdate()
    {
            transform.position = player.position + distancia;   

    }

}
